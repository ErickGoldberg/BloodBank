using BloodBank.Application.DTOs;

namespace BloodBank.Core.Repositories
{
    public interface ICepRepository
    {
        Task<CepDto?> GetAddressByCepAsync(string cep);
    }
}
