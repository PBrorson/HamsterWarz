using HamsterWarz.Shared;

namespace HamsterWarz.Client.Services
{
    public interface IHamsterService
    {
        event Action OnChange;


        List<Hamster> GameHamster { get; set; }
        List<Hamster> Hamsters { get; set; }
        Hamster hamster { get; set; }
        Task CreateGame();
        Task GetRandomHamster();
        Task GetHamsters();
        Task<Hamster> GetHamster(int id);
        Task CreateHamster(Hamster hamster);
        Task UpdateHamster(Hamster hamster);
        Task DeleteHamster(int id);
    }
}
