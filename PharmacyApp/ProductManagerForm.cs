using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class ProductManagerForm : Form
    {
        private readonly DataTable _productTable = new DataTable("productTable");

        
        public ProductManagerForm()
        {
            InitializeComponent();
        }
        
        private void ProductManagerForm_Load(object sender, EventArgs e)
        {
            InitializeDataTable();

            DataStorage.ProductAdded += ProductAdded;
        }

        private void InitializeDataTable()
        {
            ProductDataGrid.DataSource = _productTable;
            
            _productTable.Columns.Add(new DataColumn("ID", typeof(int)));
            _productTable.Columns.Add(new DataColumn("Name", typeof(string)));
            _productTable.Columns.Add(new DataColumn("Packing", typeof(int)));
            
            ProductDataGrid.Columns["ID"].HeaderText = "ID";
            ProductDataGrid.Columns["Name"].HeaderText = "Наименование товара";
            ProductDataGrid.Columns["Packing"].HeaderText = "Фасовка";
        }

        private void ProductAdded(Product product)
        {
            _productTable.Rows.Add(product.ProductID, product.Name, product.Packing);

            if (_productTable.Rows.Count == 1)
                ProductDataGrid.ClearSelection();
        }

        private void PharmacyAddButton_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "")
            {
                MessageBox.Show(@"Поле наименования товара не заполнено.", @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (ProductPacking.Text == "")
            {
                MessageBox.Show(@"Поле фасовка не заполнено.", @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (!int.TryParse(ProductPacking.Text, out int packing))
            {
                MessageBox.Show(@"Поле фасовка должно быть числом.", @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (packing <= 0)
            {
                MessageBox.Show(@"Поле фасовка должно быть больше или равно 0.", @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product lastProduct = DataStorage.products.LastOrDefault();

            int id = lastProduct?.ProductID ?? 0;

            Product product = new Product(id + 1, ProductName.Text, packing);
            
            DataStorage.AddProduct(product);
        }

        private void ProductDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    e.Value = string.Format($"{e.Value} мг.");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
