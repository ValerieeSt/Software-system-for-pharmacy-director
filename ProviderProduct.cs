namespace PharmacyApp
{
    internal class ProviderProduct
    {
        public int ProviderProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public ProviderProduct(int providerProductId, Product product, int quantity, int price)
        {
            ProviderProductId = providerProductId;
            Product = product;
            Quantity = Quantity;
            Price = price;
        }
    }
}