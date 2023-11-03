
using System;

namespace PharmacyApp
{
    internal class PharmacyProduct
    {
        public int PharmacyProductId { get; set; }
        public Product Product;
        public int Quantity {  get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }
    }
}
