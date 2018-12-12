using System;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComiAdminn.Pages.Package
{
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EditModel(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [BindProperty]
        public EditPackage InputModel { get; set; }
        public class EditPackage
        {
            public int Id { get; set; }
            [Required]
            public string Name { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }
        }
        public void OnGet(int id)
        {
            InputModel = _mapper.Map<EditPackage>(_unitOfWork.PackageRepository.Get(id));
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var package = _mapper.Map<ComiCore.Model.Package>(InputModel);
            package.ModifiedDate = DateTime.Now;
            _unitOfWork.PackageRepository.Edit(package);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}