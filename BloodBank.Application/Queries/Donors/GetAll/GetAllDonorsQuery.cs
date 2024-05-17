using BloodBank.Application.DTOs.Donors;
using MediatR;

namespace BloodBank.Application.Queries.Donors.GetAll;

public sealed record GetAllDonorsQuery(int Skip = 0, int Take = 50) : IRequest<IEnumerable<GetDonorViewModel>>;