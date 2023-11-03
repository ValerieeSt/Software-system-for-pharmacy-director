using System;
using System.Collections.Generic;

namespace PharmacyApp
{
    internal class Provider
    {
        public int ProviderId { get; set; }
        public string Name { get; set; }

        public event Action<ProviderProduct> ProductAdded;

        public List<ProviderProduct> Products { get; set; } = new List<ProviderProduct>();

        public Provider(int providerId, string name)
        {
            ProviderId = providerId;
            Name = name;
        }
        public void AddProduct(ProviderProduct providerProduct)
        {
            Products.Add(providerProduct);
            ProductAdded?.Invoke(providerProduct);
        }
    }
}
