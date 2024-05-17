using BloodBank.Core.Entities;
using MediatR;

namespace BloodBank.Application.Queries.BloodStorage.GetAll;

public sealed record GetAllBloodStocksQuery(int Skip = 0, int Take = 50) : IRequest<IEnumerable<BloodStock>>;