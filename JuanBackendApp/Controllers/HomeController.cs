using JuanBackendApp.Data;
using JuanBackendApp.Models;
using JuanBackendApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace JuanBackendApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly JuanDbContext _context;

        public HomeController(JuanDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new();
            homeVM.Sliders = await _context.Sliders.Where(s=>!s.IsDeleted).ToListAsync();
            homeVM.Categories = await _context.Categories.Where(s=>!s.IsDeleted).ToListAsync();
            homeVM.Policies = await _context.Policies.Where(s=>!s.IsDeleted).ToListAsync();
            return View(homeVM);
        }
        
    }
}
