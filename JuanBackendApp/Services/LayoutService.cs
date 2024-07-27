using JuanBackendApp.Data;
using JuanBackendApp.Interfaces;
using JuanBackendApp.Models;

namespace JuanBackendApp.Services
{
    public class LayoutService:ILayoutService
    {
        private readonly JuanDbContext _context;


        public LayoutService(JuanDbContext context)
        {
            _context = context;
        }
    }
}
