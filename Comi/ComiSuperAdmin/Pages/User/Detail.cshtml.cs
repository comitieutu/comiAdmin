using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using ComiCore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiSuperAdmin.Pages.User
{
    public class DetailModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public PersonInfo PersonInfo { get; set; }
        public void OnGet(string id)
        {
            PersonInfo = _context.PersonInfos.AsNoTracking().FirstOrDefault(p => p.UserId == id);
        }
    }
}