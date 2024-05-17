using BloodBank.Application.DTOs.Donors;
using BloodBank.Core.Repositories;
using MediatR;

namespace BloodBank.Application.Queries.Donors.GetAll
{
    internal sealed class GetAllDonorsQueryHandler : IRequestHandler<GetAllDonorsQuery, IEnumerable<GetDonorViewModel>>
    {
        private readonly IDonorRepository _donorRepository;

        public GetAllDonorsQueryHandler(IDonorRepository donorRepository)
        {
            _donorRepository = donorRepository;
        }

        public async Task<IEnumerable<GetDonorViewModel>> Handle(GetAllDonorsQuery request, CancellationToken cancellationToken)
        {
            var donors = await _donorRepository.GetAllAsync(request.Skip, request.Take);

            return _mapper.Map<IEnumerable<GetDonorViewModel>>(donors);
        }
    }
}
