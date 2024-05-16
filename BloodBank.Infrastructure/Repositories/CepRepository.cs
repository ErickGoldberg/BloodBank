using BloodBank.Application.DTOs;
using BloodBank.Core.Repositories;
using System.Text.Json;
using Serilog;

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
                    var errorMessage = "O CEP informado está inválido.";
                    
                    Log.Error(errorMessage);
                    throw new ArgumentException(errorMessage, nameof(cep));
                }
            }
            catch (Exception ex)
            {
                Log.Error($"An exception has occured in GetAddressByCepAsync method: {ex.Message}");
                throw new ArgumentException($"An error has occured: {ex}");
            }
        }
    }
}