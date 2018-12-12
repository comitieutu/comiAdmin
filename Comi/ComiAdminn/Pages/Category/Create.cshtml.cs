using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComiAdminn.Pages.Category
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
        public CreateCategoryModel InputModel { get; set; }
        public List<SelectListItem> Categories { get; set; } 
        public class CreateCategoryModel
        {
            [Required]
            public string CategoryName { get; set; }
            public string CategoryDes { get; set; }
            public int Parent { get; set; }
        }
        public void OnGet()
        {
            var cates = _unitOfWork.CategoryRepository.GetAll().Where(c => c.Parent == 0 && c.Deleted == false).ToList();
            Categories = new List<SelectListItem>();
            cates.ForEach(c => Categories.Add(new SelectListItem { Value = c.Id.ToString(), Text = c.CategoryName }));
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var category = _mapper.Map<ComiCore.Model.Category>(InputModel);
            _unitOfWork.CategoryRepository.Create(category);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}