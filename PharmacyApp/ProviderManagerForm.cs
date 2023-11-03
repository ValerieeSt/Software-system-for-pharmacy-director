using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class ProviderManagerForm : Form
    {
        private readonly DataTable _providerTable = new DataTable("providerTable");
        private readonly DataTable _providerProductTable = new DataTable("providerProductTable");
        private readonly DataTable _productListTable = new DataTable("productListTable");

        private Provider _selectedProvider = null;
        private Product _selectedProduct = null;

        public ProviderManagerForm()
        {
            InitializeComponent();
        }

        private void ProviderManagerForm_Load(object sender, EventArgs e)
        {
            InitializeDataTable();

            DataStorage.ProductAdded += ProductAdded;
            DataStorage.ProviderAdded += ProviderAdded;
        }

        private void InitializeDataTable()
        {
            ProviderDataGrid.DataSource = _providerTable;
            ProviderProductDataGrid.DataSource = _providerProductTable;
            ProductListDataGrid.DataSource = _productListTable;

            _providerTable.Columns.Add(new DataColumn("ID", typeof(int)));
            _providerTable.Columns.Add(new DataColumn("Name", typeof(string)));

            ProviderDataGrid.Columns["ID"].HeaderText = "ID";
            ProviderDataGrid.Columns["Name"].HeaderText = "Название поставщика";


            _providerProductTable.Columns.Add(new DataColumn("ID", typeof(int)));
            _providerProductTable.Columns.Add(new DataColumn("ProductID", typeof(int)));
            _providerProductTable.Columns.Add(new DataColumn("Name", typeof(string)));
            _providerProductTable.Columns.Add(new DataColumn("Price", typeof(int)));

            ProviderProductDataGrid.Columns["ID"].HeaderText = "ID";
            ProviderProductDataGrid.Columns["Name"].HeaderText = "Наименование товара";
            ProviderProductDataGrid.Columns["Price"].HeaderText = "Цена";
            ProviderProductDataGrid.Columns["ProductID"].Visible = false;


            _productListTable.Columns.Add(new DataColumn("ID", typeof(int)));
            _productListTable.Columns.Add(new DataColumn("Name", typeof(string)));

            ProductListDataGrid.Columns["ID"].Visible = false;
            ProductListDataGrid.Columns["Name"].HeaderText = "Наименование товара";
        }


        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (_selectedProvider == null)
            {
                MessageBox.Show(@"Сначала необходимо выбрать поставщика.", @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_selectedProduct == null)
            {
                MessageBox.Show(@"Необходимо выбрать товар.", @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(ProductPrice.Text, out int price))
            {
                MessageBox.Show(@"Поле цена должно быть числом.", @"Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show(@"Поле цена должно быть больше или равно 0.", @"Ошибка!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(ProductQuantity.Text, out int quantity))
            {
                MessageBox.Show(@"Поле количество должно быть числом.", @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show(@"Поле количество должно быть больше или равно 0.", @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow[] rows = _providerProductTable.Select("ProductID = " + _selectedProduct.ProductID);

            if (rows.Length > 0)
            {
                MessageBox.Show(@"Товар уже добавлен в каталог поставщика.", @"Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            ProviderProduct lastProviderProduct = _selectedProvider.Products.LastOrDefault();

            int id = lastProviderProduct?.ProviderProductId ?? 0;

            ProviderProduct providerProduct = new ProviderProduct(id + 1, _selectedProduct, quantity, price);

            _selectedProvider.AddProduct(providerProduct);
            
            _providerProductTable.Rows.Add(
                providerProduct.ProviderProductId,
                providerProduct.Product.ProductID,
                providerProduct.Product.Name,
                price
            );
            
            if (_providerProductTable.Rows.Count == 1)
                ProviderProductDataGrid.ClearSelection();
        }

        private void ProviderDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ProductAdded(Product product)
        {
            _productListTable.Rows.Add(product.ProductID, product.Name);
            
            if (_productListTable.Rows.Count == 1)
                ProductListDataGrid.ClearSelection();
        }

        private void ProductListDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; 
            int.TryParse(ProductListDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id);

            Product product = DataStorage.products.Find(p => p.ProductID == id);
            _selectedProduct = product;
        }
        
        private void ProviderAdded(Provider provider)
        {
            _providerTable.Rows.Add(provider.ProviderId, provider.Name);
            
            if (_providerTable.Rows.Count == 1)
                ProviderDataGrid.ClearSelection();
        }

        private void ProviderAddButton_Click(object sender, EventArgs e)
        {
            if (ProvidertName.Text == "")
            {
                MessageBox.Show(@"Поле название провайдера не заполнено.", @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Provider lastProvider = DataStorage.providers.LastOrDefault();

            int id = lastProvider?.ProviderId ?? 0;

            Provider provider = new Provider(id + 1, ProvidertName.Text);
            
            DataStorage.AddProvider(provider);
        }

        private void ProviderProductDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProviderDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; 
            int.TryParse(ProviderDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id);

            Provider provider = DataStorage.providers.Find(p => p.ProviderId == id);

            _selectedProvider = provider;
        }
    }
}