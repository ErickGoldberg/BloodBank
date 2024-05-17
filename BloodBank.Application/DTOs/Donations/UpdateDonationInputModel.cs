namespace BloodBank.Application.DTOs.Donations;
public record UpdateDonationInputModel(DateTime DonationDate, int AmountInML, bool IsActive);