using Catalyst4Change.ApiService.Data;

namespace Catalyst4Change.Web.Services
{
    public class NGOApiClient
    {
        private readonly HttpClient _httpClient;

        public NGOApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<NGO>> GetNGOsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<NGO>>("api/NGO");
        }

        public async Task<NGO> GetNGOAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<NGO>($"api/NGO/{id}");
        }

        public async Task<NGO> CreateNGOAsync(NGO ngo)
        {
            var response = await _httpClient.PostAsJsonAsync("api/NGO", ngo);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<NGO>();
        }

        public async Task UpdateNGOAsync(int id, NGO ngo)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/NGO/{id}", ngo);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteNGOAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/NGO/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
