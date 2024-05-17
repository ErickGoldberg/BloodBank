using BloodBank.Application.DTOs.Address;

namespace BloodBank.Application.DTOs.Donors;

public sealed record UpdateDonorInputModel(string Name, string Email, DateTime BirthDate, string Gender, double Weight, string BloodType, string RhFactor, AddressModel Address, bool IsActive);