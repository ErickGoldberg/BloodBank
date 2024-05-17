using BloodBank.Application.DTOs.Donations;
using BloodBank.Core.Repositories;
using MediatR;

namespace BloodBank.Application.Queries.Donations.GetById
{
    internal class GetDonationByIdQueryHandler
    {
    }

    public sealed class GetDonationByIdQueryHandler : IRequestHandler<GetDonationByIdQuery, GetDonationViewModel?>
    {
        private readonly IDonationRepository _donationRepository;

        public GetDonationByIdQueryHandler(IDonationRepository donationRepository)
        {
            _donationRepository = donationRepository;
        }

        public async Task<GetDonationViewModel?> Handle(GetDonationByIdQuery request, CancellationToken cancellationToken)
        {
            var donation = await _donationRepository.GetByIdAsync(request.Id);

            return _mapper.Map<GetDonationViewModel>(donation);
        }
    }
}
