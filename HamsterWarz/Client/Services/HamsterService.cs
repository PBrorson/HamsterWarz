using HamsterWarz.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;

namespace HamsterWarz.Client.Services
{
    public class HamsterService : IHamsterService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public event Action OnChange;

        public HamsterService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<Hamster> Hamsters { get; set; } = new List<Hamster>();
        public Hamster hamster { get; set; } = new Hamster();

        public List<Hamster> GameHamster { get; set; } = new List<Hamster>();
        public async Task CreateHamster(Hamster hamster)
        {
            var result = await _http.PostAsJsonAsync("hamster", hamster);
            await SetHamsters(result);
        }

        private async Task SetHamsters(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Hamster>>();
            Hamsters = response;
            //_navigationManager.NavigateTo("hamster");
        }

        public async Task DeleteHamster(int id)
        {
            var result = await _http.DeleteAsync($"hamster/{id}");
            await SetHamsters(result);
        }


        public async Task<Hamster> GetHamster(int id)
        {
            var result = await _http.GetFromJsonAsync<Hamster>($"hamster/{id}");
            if (result != null)
                return result;
            throw new Exception("Hamster not found!");
        }

        public async Task GetHamsters()
        {
            var result = await _http.GetFromJsonAsync<List<Hamster>>("hamster");
            if (result != null)
                Hamsters = result;
        }

        public async Task UpdateHamster(Hamster hamster)
        {
            var result = await _http.PutAsJsonAsync($"hamster/{hamster.Id}", hamster);
            await SetHamsters(result);
        }

        public async Task GetRandomHamster()
        {
            var result = await _http.GetFromJsonAsync<Hamster>($"Hamster/random");
            if (result != null)
                hamster = result;
        }
        public async Task CreateGame()
        {
            List<Hamster> hamsters = new List<Hamster>();
            var result1 = await _http.GetFromJsonAsync<Hamster>($"Hamster/random");
            var result2 = await _http.GetFromJsonAsync<Hamster>($"Hamster/random");

            if(result1!= result2)
            {
                hamsters.Add(result1);
                hamsters.Add(result2);
            }
            GameHamster = hamsters;
        }
    }


}