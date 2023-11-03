using System;
using System.Collections.Generic;
using System.Linq;

namespace PharmacyApp
{
    internal class Pharmacy
    {
        public int PharmacyID { get; set; }
        public string Name { get; set; }
        public List<PharmacyProduct> Products { get; set; } = new List<PharmacyProduct>();
        public List<PharmacyProvider> Providers { get; set; } = new List<PharmacyProvider>();

        public int TotalProductQuantity { get; set; } = 0;

        public Pharmacy(int PharmacyID, string Name)
        {
            this.PharmacyID = PharmacyID;
            this.Name = Name;
        }

        public void AddProduct(Product product, int quantity, int price)
        {

            PharmacyProduct lastProduct = Products.LastOrDefault();

            int id = lastProduct?.PharmacyProductId ?? 0;

            Random random = new Random();

            int currentYear = DateTime.Now.Year;
            int randomMonth = random.Next(1, 13);
            int randomDay = random.Next(1, 30);

            DateTime randomDate = new DateTime(currentYear, randomMonth, randomDay);

            Products.Add(new PharmacyProduct()
            {
                PharmacyProductId = id + 1,
                Product = product,
                Quantity = quantity,
                ExpiryDate = randomDate,
                Price = price
            });
        }
    }
}
