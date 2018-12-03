using ComiCore;
using ComiCore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComiAdmin.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public MenuViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private Task<List<Category>> GetItemsAsync()
        {
            return _context.Categories.ToListAsync();
        }
    }
}
