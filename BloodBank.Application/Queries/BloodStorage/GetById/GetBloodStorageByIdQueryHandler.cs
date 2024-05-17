using BloodBank.Core.Entities;
using BloodBank.Core.Repositories;
using MediatR;

namespace BloodBank.Application.Queries.BloodStorage.GetById
{
    public class GetBloodStockByIdQueryHandler : IRequestHandler<GetBloodStockByIdQuery, BloodStock?>
    {
        private readonly IBloodStockRepository _bloodStockRepository;

        public GetBloodStockByIdQueryHandler(IBloodStockRepository bloodStockRepository)
        {
            _bloodStockRepository = bloodStockRepository;
        }

        public async Task<BloodStock?> Handle(GetBloodStockByIdQuery request, CancellationToken cancellationToken)
        {
            var stockOfBlood = await _bloodStockRepository.GetByIdAsync(request.Id);

            return stockOfBlood;
        }
    }
}