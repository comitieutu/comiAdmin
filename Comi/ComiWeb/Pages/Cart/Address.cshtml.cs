using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using ComiCore.Model;
using ComiService.Common;
using ComiService.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ComiWeb.Pages.Cart
{
    public class AddressModel : AddressInfoPageModel
    {
        private readonly ApplicationDbContext _context;

        public AddressModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public ReceiveProduct ReceiveProduct { get; set; }
        public void OnGet()
        {
            DistrictDropDownList(_context);
            StateOrProvinceDropDownList(_context);
            CountryDropDownList(_context);
        }
        public IActionResult OnGetCity(int id)
        {
            var result = new ContentResult();
            if (id == 0)
            {
                var districts = _context.Districts.AsNoTracking().Select(d => new { d.Id, d.Name });
                result.Content = JsonConvert.SerializeObject(districts, Formatting.Indented);
            }
            else
            {
                var districts = _context.Districts.AsNoTracking().Where(d => d.StateOrProvinceId == id).Select(d => new { d.Id, d.Name });
                result.Content = JsonConvert.SerializeObject(districts, Formatting.Indented);
            }
            return result;
        }
        public IActionResult OnGetDistrict(int id)
        {
            var result = new ContentResult();
            if (id == 0)
            {
                var state = _context.StateOrProvinces.AsNoTracking().Select(s => new { s.Id, s.Name }).ToList();
                result.Content = JsonConvert.SerializeObject(state, Formatting.Indented);
            }
            else
            {
                var state = _context.StateOrProvinces.AsNoTracking().Where(s => s.Id == _context.Districts.FirstOrDefault(d => d.Id == id).StateOrProvinceId)
                    .Select(s => new { s.Id, s.Name });
                result.Content = JsonConvert.SerializeObject(state, Formatting.Indented);
            }
            return result;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "address", ReceiveProduct);
            return RedirectToPage("/Cart/DeliveryMethod");
        }        
    }
}