using System.ComponentModel.DataAnnotations;
using System.Linq;
using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComiAdminn.Pages.Package
{
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateModel(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [BindProperty]
        public CreatePackageModel InputModel { get; set; }
        public class CreatePackageModel
        {
            [Required]
            public string Name { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var package = _mapper.Map<ComiCore.Model.Package>(InputModel);
            _unitOfWork.PackageRepository.Create(package);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}