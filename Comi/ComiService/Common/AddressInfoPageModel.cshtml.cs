using ComiCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComiService.Common
{
    public class AddressInfoPageModel : PageModel
    {
        public SelectList StateOrProvinces { get; set; }
        public SelectList Districts { get; set; }
        public SelectList Countries { get; set; }

        public void StateOrProvinceDropDownList(ApplicationDbContext _context, object selectedStateOrProvince = null)
        {
            var stateOrProvincesQuery = _context.StateOrProvinces;

            StateOrProvinces = new SelectList(stateOrProvincesQuery.AsNoTracking(), "Id", "Name", selectedStateOrProvince);
        }
        public void DistrictDropDownList(ApplicationDbContext _context, object selectedDistrict = null)
        {
            var districtsQuery = _context.Districts;

            Districts = new SelectList(districtsQuery.AsNoTracking(), "Id", "Name", selectedDistrict);
        }
        public void CountryDropDownList(ApplicationDbContext _context, object selectedCountry = null)
        {
            var countrysQuery = _context.Countries.Where(c => c.Id == "VN");

            Countries = new SelectList(countrysQuery.AsNoTracking(), "Id", "Name", selectedCountry);
        }
    }
}
