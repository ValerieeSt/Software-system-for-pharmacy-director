using System;
using System.Collections.Generic;

namespace PharmacyApp
{
    internal static class DataStorage
    {
        public static List<Pharmacy> pharmacies = new List<Pharmacy>();
        public static List<Product> products = new List<Product>();
        public static List<Provider> providers = new List<Provider>();

        // События для отслеживания изменений в списке pharmacies
        public static event Action<Pharmacy> PharmacyAdded;
        public static event Action<Pharmacy> PharmacyRemoved;

        // События для отслеживания изменений в списке products
        public static event Action<Product> ProductAdded;
        public static event Action<Product> ProductRemoved;

        // События для отслеживания изменений в списке providers
        public static event Action<Provider> ProviderAdded;
        public static event Action<Provider> ProviderRemoved;

        // Метод для добавления аптеки и вызова события PharmacyAdded
        public static void AddPharmacy(Pharmacy pharmacy)
        {
            pharmacies.Add(pharmacy);
            PharmacyAdded?.Invoke(pharmacy);
        }

        // Метод для удаления аптеки и вызова события PharmacyRemoved
        public static void RemovePharmacy(Pharmacy pharmacy)
        {
            pharmacies.Remove(pharmacy);
            PharmacyRemoved?.Invoke(pharmacy);
        }

        // Метод для добавления продукта и вызова события ProductAdded
        public static void AddProduct(Product product)
        {
            products.Add(product);
            ProductAdded?.Invoke(product);
        }

        // Метод для удаления продукта и вызова события ProductRemoved
        public static void RemoveProduct(Product product)
        {
            products.Remove(product);
            ProductRemoved?.Invoke(product);
        }

        // Метод для добавления поставщика и вызова события ProviderAdded
        public static void AddProvider(Provider provider)
        {
            providers.Add(provider);
            ProviderAdded?.Invoke(provider);
        }

        // Метод для удаления поставщика и вызова события ProviderRemoved
        public static void RemoveProvider(Provider provider)
        {
            providers.Remove(provider);
            ProviderRemoved?.Invoke(provider);
        }
    }
}
