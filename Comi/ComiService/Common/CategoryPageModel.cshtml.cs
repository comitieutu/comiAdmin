using ComiCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComiService.Common
{
    public class CategoryPageModel : PageModel
    {
        public SelectList Categories { get; set; }

        public void CategoryDropDownList(ApplicationDbContext _context, object selectedCategory = null)
        {
            var categoriesQuery = _context.Categories.Where(c => c.Parent != 0).OrderByDescending(c => c.CategoryName);

            Categories = new SelectList(categoriesQuery.AsNoTracking(), "Id", "CategoryName", selectedCategory);
        }
    }
}
