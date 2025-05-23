using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Music.Data.Repositories;
using Music.Data.Repositories.Interfaces;

namespace Music.Controllers;

public class SongController(ISongRepository repository) : Controller
{
    public async Task<IActionResult> Index()
    {
        var album = await repository.GetAlbumWithSongsByIdAsync(1);

        return View(album);
    }
}