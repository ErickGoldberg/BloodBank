using BloodBank.Core.Entities;
using MediatR;

namespace BloodBank.Application.Queries.BloodStorage.GetById;

public sealed record GetBloodStockByIdQuery(int Id) : IRequest<BloodStock?>;