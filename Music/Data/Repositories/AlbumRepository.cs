using Microsoft.EntityFrameworkCore;
using Music.Data.Repositories.Interfaces;
using Music.Models;

namespace Music.Data.Repositories;

public class AlbumRepository(MusicDbContext context) : IAlbumRepository
{
    public async Task<List<Album>> GetAllAsync() => await context.Albums.AsNoTracking().ToListAsync();
    

    public async Task<Album> GetDetailsByIdAsync(int id) => await context.Albums
                            .AsNoTracking()
                            .Include(album => album.Songs)
                            .FirstAsync(x => x.Id == id);
}