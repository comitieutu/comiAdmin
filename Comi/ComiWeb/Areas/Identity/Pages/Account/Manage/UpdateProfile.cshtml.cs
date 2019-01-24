using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using ComiCore.Model;
using ComiService.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ComiWeb.Areas.Identity.Pages.Account.Manage
{
    public class UpdateProfileModel : AddressInfoPageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UpdateProfileModel(ApplicationDbContext context, 
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [BindProperty]
        public PersonInfo PersonInfo { get; set; }
        [TempData]
        public string StatusMessage { get; set; }
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
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var profile = _context.PersonInfos.FirstOrDefaultAsync(p => p.UserId == _userManager.GetUserId(User));
            if (profile == null)
            {
                _context.PersonInfos.Add(PersonInfo);
            }
            else
            {
                _context.PersonInfos.Update(PersonInfo);
            }
            await _context.SaveChangesAsync();
      
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage("./Index");
        }
    }
}