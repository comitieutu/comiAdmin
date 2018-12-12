using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ComiAdminn.Pages.Product
{
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnv;

        public CreateModel(IUnitOfWork unitOfWork, IMapper mapper, IHostingEnvironment hostingEnv)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnv = hostingEnv;
        }
        [BindProperty]
        public CreateProduct InputModel { get; set; }
        [BindProperty]
        public List<IFormFile> Files { get; set; }
        public List<SelectListItem> Categories { get; set; }
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
            var cates = _unitOfWork.CategoryRepository.GetAll().Where(c => c.Parent != 0 && c.Deleted == false).ToList();
            Categories = new List<SelectListItem>();
            cates.ForEach(c => Categories.Add(new SelectListItem { Value = c.Id.ToString(), Text = c.CategoryName }));
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
                _unitOfWork.ProductRepository.Create(product);
                _unitOfWork.Commit();

                var productId = _unitOfWork.ProductRepository.GetByUId(product.UniqueId).Id;

                var filePath = _hostingEnv.WebRootPath + "\\img";
                var flag = false;
                foreach (var formFile in Files)
                {
                    var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(formFile.FileName);
                    if (formFile.Length > 0)
                    {
                        using (var stream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
                        {
                            await formFile.CopyToAsync(stream);
                        }
                        _unitOfWork.ProductDetailRepository.Create(new ComiCore.Model.ProductDetail { ProductId = productId, ProductImage = fileName });
                        flag = true;
                    }
                }
                if (flag)
                {
                    _unitOfWork.Commit();
                }
                else
                {
                    _unitOfWork.Refresh();
                }
                return RedirectToPage("./List");
            }
            catch (Exception e)
            {
                return RedirectToPage("/Error");
            }
        }
    }
}