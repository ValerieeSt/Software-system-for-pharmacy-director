namespace PharmacyApp
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Packing { get; set; }

        public Product(int productId, string name, int packing)
        {
            ProductID = productId;
            Name = name;
            Packing = packing;
        }
    }
}
