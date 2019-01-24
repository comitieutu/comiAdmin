using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ComiAdminn.Pages.FlashSale
{
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnv;
        private readonly IConfiguration _configuration;

        public EditModel(IUnitOfWork unitOfWork, IMapper mapper, IHostingEnvironment hostingEnv, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnv = hostingEnv;
            _configuration = configuration;
        }
        [BindProperty]
        public EditFlashSale InputModel { get; set; }
        [BindProperty]
        public IFormFile File { get; set; }
        public List<SelectListItem> Products { get; set; }
        public class EditFlashSale
        {
            public int Id { get; set; }
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
        public void OnGet(int id)
        {
            InputModel = _mapper.Map<EditFlashSale>(_unitOfWork.FlashSaleRepository.Get(id));
            var products = _unitOfWork.ProductRepository.GetAll().Include(p => p.Category).ToList();
            Products = new List<SelectListItem>();
            products.ForEach(p => Products.Add(new SelectListItem { Value = p.Id.ToString(), Text = $"{p.ProductName} ({p.Category.CategoryName})" }));
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
                var filePath = _configuration["Image"];
                var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(File.FileName);
                if (File.Length > 0)
                {
                    using (var stream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
                    {
                        await File.CopyToAsync(stream);
                    }
                    InputModel.Image = fileName;
                    _unitOfWork.FlashSaleRepository.Edit(_mapper.Map<ComiCore.Model.FlashSale>(InputModel));
                }
                var fsp = _unitOfWork.FlashSaleProductRepository.GetAll().Where(fp => fp.FlashSaleId == InputModel.Id).ToList();
                InputModel.ProductId.ToList().ForEach(p => {
                    fsp.ForEach(f => {
                        if (f.ProductId != p)
                        {
                            f.ProductId = p;
                            _unitOfWork.FlashSaleProductRepository.Edit(f);
                        }
                    });
                });
                _unitOfWork.Commit();
                return RedirectToPage("./List");
            }
            catch (Exception e)
            {
                return RedirectToPage("/Error");
            }
        }
    }
}