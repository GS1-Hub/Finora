using Finora.Models;
using Finora.Services.Interfaces;
using System.Net.Http.Json;

namespace Finora.Services
{
    public class FinService : IFinService
    {
        private readonly string BaseUrl = "https://localhost:7007/";

        private readonly HttpClient _http;
        public FinService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Fin>> GetAllFinsAsync()
        {
            var result = await _http.GetFromJsonAsync<List<Fin>>(BaseUrl + API.GetFins);
            return result ?? new List<Fin>();
        }
        public async Task DeleteFin(int id)
        {
            var response = await _http.DeleteAsync($"{BaseUrl}{API.DeleteFin}/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
