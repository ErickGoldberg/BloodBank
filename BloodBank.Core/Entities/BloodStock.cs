namespace BloodBank.Core.Entities
{
    public class BloodStock : BaseEntity
    {
        public int Id { get; private set; }
        public string BloodType { get; private set; }
        public string RhFactor { get; private set; }
        public int Milliliters { get; private set; }

        public BloodStock(int id, string bloodType, string rhFactor, int milliliters)
        {
            Id = id;
            BloodType = bloodType;
            RhFactor = rhFactor;
            Milliliters = milliliters;

            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsActive = true;
        }
    }
}
