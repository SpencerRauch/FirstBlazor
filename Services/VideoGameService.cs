using FirstBlazor.Data;
using FirstBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstBlazor.Services;

public class VideoGameService : IVideoGameService
{
    private readonly DataContext _context; 

    public VideoGameService(DataContext context)
    {
        _context = context;
    }
    public async Task<List<VideoGame>> GetAllGamesAsync()
    {
        var result = await _context.VideoGames.ToListAsync();
        return result;
    }
}