using BloodBank.Core.Entities;
using BloodBank.Core.Repositories;
using MediatR;

namespace BloodBank.Application.Queries.BloodStorage.GetByBloodType
{

    internal sealed class GetBloodStockByBloodTypeQueryHandler : IRequestHandler<GetBloodStockByBloodTypeQuery, BloodStock?>
    {
        private readonly IBloodStockRepository _bloodStockRepository;

        public GetBloodStockByBloodTypeQueryHandler(IBloodStockRepository bloodStockRepository)
        {
            _bloodStockRepository = bloodStockRepository;
        }

        public async Task<BloodStock?> Handle(GetBloodStockByBloodTypeQuery request, CancellationToken cancellationToken)
        {
            var bloodData = new BloodData(request.BloodType, request.RhFactor);

            var stockOfBlood = await _bloodStockRepository.GetByBloodTypeAsync(bloodData.BloodType, bloodData.RhFactor);

            return stockOfBlood;
        }
    }
}
