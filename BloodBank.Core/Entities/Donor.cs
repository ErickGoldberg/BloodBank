namespace BloodBank.Core.Entities
{
    public class Donor : BaseEntity
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Gender { get; private set; }
        public double Weight { get; private set; }
        public string BloodType { get; private set; }
        public string RhFactor { get; private set; }
        public List<Donation> Donations { get; private set; }
        public Address Address { get; private set; }

        public Donor(int id, string fullName, string email, DateTime dateOfBirth, string gender, double weight, string bloodType, string rhFactor, List<Donation> donations, Address address)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Weight = weight;
            BloodType = bloodType;
            RhFactor = rhFactor;
            Donations = donations;
            Address = address;

            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsActive = true;
        }
    }
}
