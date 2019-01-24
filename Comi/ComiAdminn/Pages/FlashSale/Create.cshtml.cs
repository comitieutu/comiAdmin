using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiCore;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;

namespace ComiAdminn.Pages.FlashSale
{
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnv;
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public CreateModel(IUnitOfWork unitOfWork, IMapper mapper, IHostingEnvironment hostingEnv, ApplicationDbContext applicationDbContext, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnv = hostingEnv;
            _context = applicationDbContext;
            _configuration = configuration;
        }
        [BindProperty]
        public CreateFlashSale InputModel { get; set; }
        [BindProperty]
        public IFormFile File { get; set; }
        public List<SelectListItem> Products { get; set; }
        public class CreateFlashSale
        {
            public string Name { get; set; }
            [DataType(DataType.DateTime)]
            public DateTime StartDate { get; set; }
            [DataType(DataType.DateTime)]
            public DateTime EndDate { get; set; }
            public string Description { get; set; }
            public int Sale { get; set; }
            public string Image { get; set; }
            public IEnumerable<int> ProductId { get; set; }
        }
        public void OnGet()
        {
            var products = _context.Products.Include(p => p.Category).ToList();
            Products = new List<SelectListItem>();
            products.ForEach(p => Products.Add(new SelectListItem { Value = p.Id.ToString(), Text = $"{p.ProductName} ({p.Category.CategoryName})"}));
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
                //var filePath = _hostingEnv.WebRootPath + "\\img";
                var filePath =  _configuration["Image"];
                var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(File.FileName);
                if (File.Length > 0)
                {
                    using (var stream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
                    {
                        await File.CopyToAsync(stream);
                    }
                }
                InputModel.Image = fileName;
                var entry = _context.Add(new ComiCore.Model.FlashSale());
                entry.CurrentValues.SetValues(InputModel);
                _context.SaveChanges();

                InputModel.ProductId.ToList().ForEach(p => _context.FlashSaleProducts.Add(new ComiCore.Model.FlashSaleProduct { ProductId = p, FlashSaleId = entry.Entity.Id}));
                _context.SaveChanges();
                return RedirectToPage("./List");
            }
            catch (Exception e)
            {
                return RedirectToPage("/Error");
            }
        }
    }
}