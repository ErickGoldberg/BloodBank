using BloodBank.Core.Entities;
using BloodBank.Core.Repositories;
using MediatR;

namespace BloodBank.Application.Queries.BloodStorage.GetAll
{
    public sealed class GetBloodStoragesQueryHandler : IRequestHandler<GetAllBloodStocksQuery, IEnumerable<BloodStock>>
    {
        private readonly IBloodStockRepository _bloodStockRepository;

        public GetBloodStoragesQueryHandler(IBloodStockRepository bloodStockRepository)
        {
            _bloodStockRepository = bloodStockRepository;
        }

        public async Task<IEnumerable<BloodStock>> Handle(GetAllBloodStocksQuery request, CancellationToken cancellationToken)
        {
            var stockOfBloods = await _bloodStockRepository.GetAllAsync(request.Skip, request.Take);

            return stockOfBloods;
        }
    }
}