using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interfaces;
using RunWebAppGroup.Models;

namespace RunGroopWebApp.Controllers
{
    public class ClubController : Controller
    {

        private readonly IClubRepository _clubRepository;

        public ClubController(IClubRepository clubRepository)
        { 
            _clubRepository = clubRepository;
        }
        public async Task<IActionResult> Index() //C
        {
            IEnumerable<Club> clubs = await _clubRepository.GetAll(); //M
            return View(clubs); //V
        }

        //Detail Page so only one club, not a list like Index
        public async Task<IActionResult> Detail(int id)
        {
            Club club = await _clubRepository.GetByIDAsync(id);
            return View(club);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Club club)
        {
            if (!ModelState.IsValid) 
            {
                return View(club);
            }
            _clubRepository.Add(club);
            return RedirectToAction("Index");
        }

    }
}
