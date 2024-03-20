namespace EasyPOS.Domain.ValueObjects
{
    public partial record Address
    {
        public Address(string country, string line1, string line2, string city, string state, string zipCode)
        {
            Country = country;
            Line1 = line1;
            Line2 = line2;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public string Country { get; }
        public string Line1 { get; }
        public string Line2 { get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
        public static Address? Create(string country, string line1, string line2, string city, string state, string zipCode)
        {
            if (string.IsNullOrEmpty(country) || string.IsNullOrEmpty(line1) ||
                string.IsNullOrEmpty(line2) || string.IsNullOrEmpty(city) ||
                string.IsNullOrEmpty(state) || string.IsNullOrEmpty(zipCode))
            {
                return null;
            }
            return new Address(country, line1, line2, city, state, zipCode);
        }
    }
}
