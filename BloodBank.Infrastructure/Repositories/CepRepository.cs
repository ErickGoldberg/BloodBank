using BloodBank.Application.DTOs;
using BloodBank.Core.Repositories;
using System.Text.Json;

namespace BloodBank.Infrastructure.Repositories
{
    public class CepRepository : ICepRepository
    {
        public HttpClient _httpClient { get; set; }
        public CepRepository()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://viacep.com.br/")
            };
        }

        public async Task<CepDto?> GetAddressByCepAsync(string cep)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"ws/{cep}/json/");

                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Content.ReadAsStringAsync();

                    return JsonSerializer.Deserialize<CepDto>(jsonContent);
                }
                else
                {
                    // passar msg para o log
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                // criar log de erro aq
                return null;
            }
        }
    }
}