using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiCore;
using ComiService.Common;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ComiAdminn.Pages.Product
{
    public class CreateModel : CategoryPageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnv;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateModel(IUnitOfWork unitOfWork, IMapper mapper, IHostingEnvironment hostingEnv, 
            IConfiguration configuration, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnv = hostingEnv;
            _configuration = configuration;
            _context = context;
            _userManager = userManager;
        }
        [BindProperty]
        public CreateProduct InputModel { get; set; }
        [BindProperty]
        public List<IFormFile> Files { get; set; }
        public class CreateProduct
        {
            public string ProductName { get; set; }
            public string ProductDes { get; set; }
            public int CategoryId { get; set; }
            public int Quantity { get; set; }
            public double UnitPrice { get; set; }
            public string Brand { get; set; }
            public string DesDetail { get; set; }
        }
        public void OnGet()
        {
            var cates = _unitOfWork.CategoryRepository.GetAll().Where(c => c.Parent != 0).ToList();
            CategoryDropDownList(_context);
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            try
            {
                var product = _mapper.Map<ComiCore.Model.Product>(InputModel);
                var productDetails = new List<ComiCore.Model.ProductDetail>();

                var filePath = _configuration["Image"];
                foreach (var formFile in Files)
                {
                    var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(formFile.FileName);
                    if (formFile.Length > 0)
                    {
                        using (var stream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
                        {
                            await formFile.CopyToAsync(stream);
                        }
                       productDetails.Add(new ComiCore.Model.ProductDetail { ProductImage = fileName });
                    }
                }
                product.ProductDetails = productDetails;
                product.User = await _userManager.GetUserAsync(User);
                _context.Products.Add(product);
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