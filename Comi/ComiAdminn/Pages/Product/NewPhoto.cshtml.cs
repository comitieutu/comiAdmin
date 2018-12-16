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

namespace ComiAdminn.Pages.Product
{
    public class NewPhotoModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnv;

        public NewPhotoModel(IUnitOfWork unitOfWork, IMapper mapper, IHostingEnvironment hostingEnv)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnv = hostingEnv;
        }
        [BindProperty]
        public List<IFormFile> Files { get; set; }
        [BindProperty]
        public int Id { get; set; }
        public void OnGet(int id)
        {
            Id = id;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
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
                        _unitOfWork.ProductDetailRepository.Create(new ComiCore.Model.ProductDetail { ProductId = Id, ProductImage = fileName });
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