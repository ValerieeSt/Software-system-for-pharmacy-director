namespace PharmacyApp
{
    internal class PharmacyProvider
    {
        public int PharmacyProviderId;
        public Provider Provider { get; set; }
        public int Preference { get; set; } // Предпочтение 1, 2, 3 ????

        public PharmacyProvider(int pharmacyProviderId, Provider provider, int preference)
        {
            PharmacyProviderId = pharmacyProviderId;
            Provider = provider;
            Preference = preference;
        }
    }
}
