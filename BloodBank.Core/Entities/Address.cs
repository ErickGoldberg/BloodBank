namespace BloodBank.Core.Entities
{
    public class Address : BaseEntity
    {
        public int Id { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public Donor Donor { get; private set; }

        public Address(int id, string street, string city, string state, string zipCode, Donor donor)
        {
            Id = id;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
            Donor = donor;

            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsActive = true;
        }
    }
}
