namespace BloodBank.Application.DTOs.Donors;

public record GetDonorViewModel(int Id, string Name, string Email, DateTime BirthDate, string Gender, double Weight, BloodData BloodData, Address Address, bool IsActive);