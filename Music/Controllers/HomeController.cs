using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Music.Data.Repositories;
using Music.Data.Repositories.Interfaces;

namespace Music.Controllers;

public class HomeController(IArtistRepository repository) : Controller
{
    public async Task<IActionResult> Index()
    {
        var artists = await repository.GetAllAsync();

        return View(artists);
    }
}
