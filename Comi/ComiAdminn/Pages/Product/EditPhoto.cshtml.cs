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
    public class EditPhotoModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnv;

        public EditPhotoModel(IUnitOfWork unitOfWork, IMapper mapper, IHostingEnvironment hostingEnv)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnv = hostingEnv;
        }
        [BindProperty]
        public IFormFile FilePhoto{ get; set; }
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
                var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(FilePhoto.FileName);
                if (FilePhoto.Length > 0)
                {
                    using (var stream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
                    {
                        await FilePhoto.CopyToAsync(stream);
                    }
                    var productDetail = _unitOfWork.ProductDetailRepository.Get(Id);
                    productDetail.ProductImage = fileName;
                    _unitOfWork.ProductDetailRepository.Edit(productDetail);
                    _unitOfWork.Commit();
                    return RedirectToPage("./Detail", new { id = productDetail.ProductId });
                }
                return Page();
            }
            catch (Exception e)
            {
                return RedirectToPage("/Error");
            }
        }
    }
}