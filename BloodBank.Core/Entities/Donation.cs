namespace BloodBank.Core.Entities
{
    public class Donation : BaseEntity
    {
        public int Id { get; private set; }
        public int DonorId { get; private set; }
        public DateTime DonationDate { get; private set; }
        public int Milliliters { get; private set; }
        public Donor Donor { get; set; }

        public Donation(int id, int donorId, DateTime donationDate, int milliliters, Donor donor)
        {
            Id = id;
            DonorId = donorId;
            DonationDate = donationDate;
            Milliliters = milliliters;
            Donor = donor;

            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsActive = true;
        }
    }
}
