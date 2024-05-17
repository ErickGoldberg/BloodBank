using BloodBank.Application.DTOs.Donations;
using MediatR;

namespace BloodBank.Application.Queries.Donations.GetById

public sealed record GetDonationByIdQuery(int Id) : IRequest<GetDonationViewModel?>;