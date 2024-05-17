namespace BloodBank.Application.DTOs.Donations;

public record GetDonationViewModel(int Id, int DonorId, DateTime DonationDate, int AmountInML, bool IsActive);