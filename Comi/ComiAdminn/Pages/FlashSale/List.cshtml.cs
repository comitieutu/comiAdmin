using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComiAdminn.Pages.FlashSale
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ListModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<FlashSaleModel> FlashSaleModels { get; set; }
        public class FlashSaleModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Description { get; set; }
            public int Sale { get; set; }
            public string Image { get; set; }
        }
        public void OnGet()
        {
            //var entry = _context.Add();
            //entry.CurrentValues.SetValues(FlashSaleModels);
        }
        //public IActionResult OnGetDelete(int id)
        //{
        //}
    }
}