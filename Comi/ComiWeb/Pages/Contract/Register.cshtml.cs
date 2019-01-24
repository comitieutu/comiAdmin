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

namespace ComiWeb.Pages.Contract
{
    public class RegisterModel : AddressInfoPageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public RegisterModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        [BindProperty]
        public PersonInfo PersonInfo { get; set; }
        public IList<Package> Packages { get; set; }
        [BindProperty]
        public ComiCore.Model.Contract Contract { get; set; }
        [BindProperty]
        public Warehouse Warehouse { get; set; }
        [BindProperty]
        public Bank Bank { get; set; }
        [BindProperty]
        public Vendor Vendor { get; set; }
        public void OnGet()
        {
            var user = _userManager.GetUserAsync(User);
            PersonInfo = _context.PersonInfos.FirstOrDefault(p => p.UserId == _userManager.GetUserId(User));
            Packages = _context.Packages.AsNoTracking().ToList();
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
            if (PersonInfo == null)
            {
                PersonInfo.UserId = _userManager.GetUserId(User);
                _context.PersonInfos.Add(PersonInfo);
                _context.SaveChanges();
            }
            Vendor.Bank = Bank;
            Vendor.Warehouse = Warehouse;
            var user = await _userManager.GetUserAsync(User);
            await _userManager.AddToRoleAsync(user, Enum.GetName(typeof(Role), 3));
            Vendor.User = user;
            Contract.Vendor = Vendor;
            _context.Contracts.Add(Contract);
            _context.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}