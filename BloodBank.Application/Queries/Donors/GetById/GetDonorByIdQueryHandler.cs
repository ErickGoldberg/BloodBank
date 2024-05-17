using BloodBank.Application.DTOs.Donors;
using BloodBank.Core.Repositories;
using MediatR;

namespace BloodBank.Application.Queries.Donors.GetById
{
    public sealed class GetDonorByIdQueryHandler : IRequestHandler<GetDonorByIdQuery, GetDonorViewModel>
    {
        private readonly IDonorRepository _donorRepository;

        public GetDonorByIdQueryHandler(IDonorRepository donorRepository)
        {
            _donorRepository = donorRepository;
        }

        public async Task<GetDonorViewModel> Handle(GetDonorByIdQuery request, CancellationToken cancellationToken)
        {
            var donor = await _donorRepository.GetByIdAsync(request.Id);

            return _mapper.Map<GetDonorViewModel>(donor);
        }
    }

}
