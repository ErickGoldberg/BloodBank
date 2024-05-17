using BloodBank.Core.Entities;
using MediatR;

namespace BloodBank.Application.Queries.BloodStorage.GetByBloodType;

public sealed record GetBloodStockByBloodTypeQuery(string BloodType, string RhFactor) : IRequest<BloodStock?>;