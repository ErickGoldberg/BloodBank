using BloodBank.Application.DTOs.Donations;
using BloodBank.Core.Repositories;
using MediatR;

namespace BloodBank.Application.Queries.Donations.GetAll
{
    public sealed class GetAllDonationsQueryHandler : IRequestHandler<GetAllDonationsQuery, IEnumerable<GetDonationViewModel>>
    {
        private readonly IDonationRepository _donationRepository;

        public GetAllDonationsQueryHandler(IDonationRepository donationRepository)
        {
            _donationRepository = donationRepository;
        }

        public async Task<IEnumerable<GetDonationViewModel>> Handle(GetAllDonationsQuery request, CancellationToken cancellationToken)
        {
            var donations = await _donationRepository.GetAllAsync(request.Skip, request.Take);

            return _mapper.Map<IEnumerable<GetDonationViewModel>>(donations);
        }
    }
}
