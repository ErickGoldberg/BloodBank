using BloodBank.Application.DTOs.Donors;
using MediatR;

namespace BloodBank.Application.Queries.Donors.GetById

public sealed record GetDonorByIdQuery(int Id) : IRequest<GetDonorViewModel>;