using FirstBlazor.Models;

namespace FirstBlazor.Services;

public interface IVideoGameService
{
    Task<List<VideoGame>> GetAllGamesAsync();
}