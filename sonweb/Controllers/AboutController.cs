using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sonweb.DAL;
using sonweb.Models;

namespace sonweb.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public AboutController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            List<TeamMember> members = await _appDbContext.TeamMembers.ToListAsync();

            return View(members);
        }
    }
}
