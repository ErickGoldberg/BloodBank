using BloodBank.Application.DTOs.Donations;
using MediatR;

namespace BloodBank.Application.Queries.Donations.GetAll;

public sealed record GetAllDonationsQuery(int Skip = 0, int Take = 50) : IRequest<IEnumerable<GetDonationViewModel>>;