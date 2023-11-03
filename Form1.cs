using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class Form1 : Form
    {
        private readonly DataTable _pharmacyTable = new DataTable("pharmacyTable");
        private readonly DataTable _pharmacyProductTable = new DataTable("pharmacyProductTable");
        private readonly DataTable _pharmacyProviderTable = new DataTable("pharmacyProviderTable");
        private readonly DataTable _providerProductTable = new DataTable("providerProductTable");
        private readonly DataTable _providerListTable = new DataTable("providerListTable");


        private Pharmacy _selectedPharmacy = null;
        private Provider _selectedProvider = null;
        private PharmacyProduct _selectedPharmacyProduct = null;
        private ProviderProduct _selectedProviderProduct = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataTable();

            DataStorage.PharmacyAdded += PharmacyAdded;
            DataStorage.ProviderAdded += ProviderAdded;
        }

        private void InitializeDataTable()
        {
            PharmacyDataGrid.DataSource = _pharmacyTable;
            PharmacyProductDataGrid.DataSource = _pharmacyProductTable;
            PharmacyProviderDataGrid.DataSource = _pharmacyProviderTable;
            ProviderProductDataGrid.DataSource = _providerProductTable;
            ProviderListDataGrid.DataSource = _providerListTable;

            _pharmacyTable.Columns.Add(new DataColumn("ID", typeof(int)));
            _pharmacyTable.Columns.Add(new DataColumn("Name", typeof(string)));
            _pharmacyTable.Columns.Add(new DataColumn("ProductQuantity", typeof(string)));
            _pharmacyTable.Columns.Add(new DataColumn("ProductTotalPrice", typeof(string)));

            PharmacyDataGrid.Columns["ID"].HeaderText = "ID";
            PharmacyDataGrid.Columns["Name"].HeaderText = "Название аптеки";
            PharmacyDataGrid.Columns["ProductQuantity"].HeaderText = "Количество товаров";
            PharmacyDataGrid.Columns["ProductTotalPrice"].HeaderText = "Сумм. стоимость товаров";


            _pharmacyProductTable.Columns.Add(new DataColumn("ID", typeof(int)));
            _pharmacyProductTable.Columns.Add(new DataColumn("Name", typeof(string)));
            _pharmacyProductTable.Columns.Add(new DataColumn("Quantity", typeof(string)));
            _pharmacyProductTable.Columns.Add(new DataColumn("ExpiryDate", typeof(string)));

            PharmacyProductDataGrid.Columns["ID"].HeaderText = "ID";
            PharmacyProductDataGrid.Columns["Name"].HeaderText = "Наименование товара";
            PharmacyProductDataGrid.Columns["Quantity"].HeaderText = "Количество";
            PharmacyProductDataGrid.Columns["ExpiryDate"].HeaderText = "Срок действия";


            _pharmacyProviderTable.Columns.Add(new DataColumn("ID", typeof(int)));
            _pharmacyProviderTable.Columns.Add(new DataColumn("Name", typeof(string)));
            _pharmacyProviderTable.Columns.Add(new DataColumn("Preference", typeof(int)));

            PharmacyProviderDataGrid.Columns["ID"].HeaderText = "ID";
            PharmacyProviderDataGrid.Columns["Name"].HeaderText = "Наименование товара";
            PharmacyProviderDataGrid.Columns["Preference"].HeaderText = "Предпочтение";
            PharmacyProviderDataGrid.Columns["Preference"].SortMode = DataGridViewColumnSortMode.Automatic;


            _providerProductTable.Columns.Add(new DataColumn("ID", typeof(int)));
            _providerProductTable.Columns.Add(new DataColumn("Name", typeof(string)));
            _providerProductTable.Columns.Add(new DataColumn("Quantity", typeof(string)));

            ProviderProductDataGrid.Columns["ID"].HeaderText = "ID";
            ProviderProductDataGrid.Columns["Name"].HeaderText = "Наименование товара";
            ProviderProductDataGrid.Columns["Quantity"].HeaderText = "Количество";

            _providerListTable.Columns.Add(new DataColumn("ID", typeof(int)));
            _providerListTable.Columns.Add(new DataColumn("Name", typeof(string)));

            ProviderListDataGrid.Columns["ID"].Visible = false;
            ProviderListDataGrid.Columns["Name"].HeaderText = "Название поставщика";
        }

        private void PharmacyAdded(Pharmacy pharmacy)
        {
            _pharmacyTable.Rows.Add(pharmacy.PharmacyID, pharmacy.Name, 0);
            if (_pharmacyTable.Rows.Count == 1)
                PharmacyDataGrid.ClearSelection();
        }

        private void PharmacyAddButton_Click(object sender, EventArgs e)
        {
            if (PharmacyName.Text == "")
            {
                MessageBox.Show(@"Поле наименования аптеки не заполнено.", @"Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Pharmacy lastPharmacy = DataStorage.pharmacies.LastOrDefault();

            int id = lastPharmacy?.PharmacyID ?? 0;

            Pharmacy pharmacy = new Pharmacy(id + 1, PharmacyName.Text);

            DataStorage.AddPharmacy(pharmacy);
        }

        private void PharmacyDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void PharmacyProductDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int.TryParse(PharmacyProductDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id);

            _selectedPharmacyProduct = _selectedPharmacy.Products.Find(p => p.PharmacyProductId == id);

            DeletePharmacyProductButton.Enabled = true;
        }

        private void AddProviderButton_Click(object sender, EventArgs e)
        {
            if (_selectedPharmacy == null)
            {
                MessageBox.Show(@"Сначала необходимо выбрать аптеку.", @"Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (_selectedProvider == null)
            {
                MessageBox.Show(@"Необходимо выбрать поставщика.", @"Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(Preference.Text, out int preference))
            {
                MessageBox.Show(@"Поле предпочтения должно быть числом.", @"Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (preference <= 0)
            {
                MessageBox.Show(@"Поле предпочтения должно быть больше или равно 0.", @"Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (_selectedPharmacy.Providers.Exists(p => p.Provider.ProviderId == _selectedProvider.ProviderId))
            {
                MessageBox.Show(@"Этот поставщик уже добавлен.", @"Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            PharmacyProvider lastProviderProduct = _selectedPharmacy.Providers.LastOrDefault();

            int id = lastProviderProduct?.PharmacyProviderId ?? 0;

            PharmacyProvider pharmacyProvider = new PharmacyProvider(id + 1, _selectedProvider, preference);
            _selectedPharmacy.Providers.Add(pharmacyProvider);

            _pharmacyProviderTable.Rows.Add(
                pharmacyProvider.PharmacyProviderId,
                pharmacyProvider.Provider.Name,
                pharmacyProvider.Preference
            );

            if (_pharmacyProviderTable.Rows.Count == 1)
                PharmacyProviderDataGrid.ClearSelection();
        }

        private void ProviderAdded(Provider provider)
        {
            _providerListTable.Rows.Add(provider.ProviderId, provider.Name);
            if (_providerListTable.Rows.Count == 1)
                ProviderListDataGrid.ClearSelection();
        }

        private void ProviderListDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int.TryParse(ProviderListDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id);

            Provider provider = DataStorage.providers.Find(p => p.ProviderId == id);
            _selectedProvider = provider;
        }

        private void PharmacyProviderDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DeletePharmacyProductButton_Click(object sender, EventArgs e)
        {
            DataRow[] rows = _pharmacyProductTable.Select("ID = " + _selectedPharmacyProduct.PharmacyProductId);

            if (rows.Length <= 0) return;
            DataRow row = rows[0];

            _selectedPharmacy.Products.Remove(_selectedPharmacyProduct);
            _pharmacyProductTable.Rows.Remove(row);
            PharmacyProductDataGrid.ClearSelection();
            _selectedPharmacyProduct = null;

            DataRow[] pharmacyRows = _pharmacyTable.Select("ID = " + _selectedPharmacy.PharmacyID);

            if (pharmacyRows.Length <= 0) return;
            DataRow pharmacyRow = pharmacyRows[0];
            pharmacyRow["ProductQuantity"] = _selectedPharmacy.Products.Count;
            pharmacyRow["ProductTotalPrice"] = _selectedPharmacy.Products.Sum(p => p.Price);
        }

        private void ProviderProductDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int.TryParse(ProviderProductDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id);

            _selectedProviderProduct = _selectedProvider.Products.Find(p => p.ProviderProductId == id);

            AddProductToPharmacyButton.Enabled = true;
        }

        private void PharmacyDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int.TryParse(PharmacyDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id);

            Pharmacy pharmacy = DataStorage.pharmacies.Find(p => p.PharmacyID == id);

            _selectedPharmacy = pharmacy;

            _pharmacyProductTable.Clear();
            _providerProductTable.Clear();
            _pharmacyProviderTable.Clear();

            pharmacy.Products.ForEach(p =>
            {
                _pharmacyProductTable.Rows.Add(
                    p.PharmacyProductId,
                    p.Product.Name,
                    p.Quantity,
                    p.ExpiryDate.ToString("dd.MM.yyyy")
                );
            });

            if (_pharmacyProductTable.Rows.Count == 1)
                PharmacyProductDataGrid.ClearSelection();

            pharmacy.Providers.ForEach(p =>
            {
                _pharmacyProviderTable.Rows.Add(p.PharmacyProviderId, p.Provider.Name, p.Preference);

                p.Provider.Products.ForEach(pp =>
                {
                    _providerProductTable.Rows.Add(pp.ProviderProductId, pp.Product.Name, pp.Quantity);
                });
            });

            if (_pharmacyProviderTable.Rows.Count == 1)
                PharmacyProductDataGrid.ClearSelection();

            if (_providerProductTable.Rows.Count == 1)
                ProviderProductDataGrid.ClearSelection();

            DeletePharmacyProductButton.Enabled = false;
        }

        private void PharmacyProviderDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int.TryParse(ProviderListDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id);

            PharmacyProvider provider = _selectedPharmacy.Providers.Find(
                p => p.PharmacyProviderId == id
            );

            _providerProductTable.Clear();

            foreach (ProviderProduct product in provider.Provider.Products)
            {
                _providerProductTable.Rows.Add(product.ProviderProductId, product.Product.Name, product.Quantity);
            }

            if (_providerProductTable.Rows.Count == 1)
                ProviderProductDataGrid.ClearSelection();
        }

        private void AddProductToPharmacyButton_Click(object sender, EventArgs e)
        {
            _selectedPharmacy.AddProduct(
                _selectedProviderProduct.Product,
                _selectedProviderProduct.Quantity,
                _selectedProviderProduct.Price
            );

            DataRow[] rows = _pharmacyTable.Select("ID = " + _selectedPharmacy.PharmacyID);

            if (rows.Length <= 0) return;
            DataRow row = rows[0];
            row["ProductQuantity"] = _selectedPharmacy.Products.Count;
            row["ProductTotalPrice"] = _selectedPharmacy.Products.Sum(p => p.Price);

            _pharmacyProductTable.Clear();

            _selectedPharmacy.Products
             .ForEach(p =>
             {
                 _pharmacyProductTable.Rows.Add(
                     p.PharmacyProductId,
                     p.Product.Name,
                     p.Quantity,
                     p.ExpiryDate.ToString("dd.MM.yyyy")
                 );
             });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_selectedPharmacy == null)
            {
                MessageBox.Show(@"Сначала необходимо выбрать аптеку.", @"Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            
            _pharmacyProductTable.Clear();

            _selectedPharmacy.Products
                .Where(p => p.ExpiryDate < DateTime.Today)
                .ToList()
                .ForEach(p =>
                {
                    _pharmacyProductTable.Rows.Add(
                        p.PharmacyProductId,
                        p.Product.Name,
                        p.Quantity,
                        p.ExpiryDate.ToString("dd.MM.yyyy")
                    );
                });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_selectedPharmacy == null)
            {
                MessageBox.Show(@"Сначала необходимо выбрать аптеку.", @"Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            
            _pharmacyProductTable.Clear();

            _selectedPharmacy.Products
                .ForEach(p =>
                {
                    _pharmacyProductTable.Rows.Add(
                        p.PharmacyProductId,
                        p.Product.Name,
                        p.Quantity,
                        p.ExpiryDate.ToString("dd.MM.yyyy")
                    );
                });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_selectedPharmacy == null)
            {
                MessageBox.Show(@"Сначала необходимо выбрать аптеку.", @"Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            
            _pharmacyProductTable.Clear();

            _selectedPharmacy.Products.RemoveAll(p => p.ExpiryDate < DateTime.Today);
            _selectedPharmacy.Products
                .ForEach(p =>
                {
                    _pharmacyProductTable.Rows.Add(
                        p.PharmacyProductId,
                        p.Product.Name,
                        p.Quantity,
                        p.ExpiryDate.ToString("dd.MM.yyyy")
                    );
                });
        }
    }
}