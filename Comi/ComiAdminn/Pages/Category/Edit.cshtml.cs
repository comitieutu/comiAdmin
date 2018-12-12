using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ComiAdminn.Pages.Category
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
        public EditCategory InputModel { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public class EditCategory
        {
            public int Id { get; set; }
            public string CategoryName { get; set; }
            public string CategoryDes { get; set; }
            public int Parent { get; set; }
        }
        public void OnGet(int id)
        {
            InputModel = _mapper.Map<EditCategory>(_unitOfWork.CategoryRepository.Get(id));

            var cates = _unitOfWork.CategoryRepository.GetAll().Where(c => c.Parent == 0 && c.Deleted == false).ToList();
            Categories = new List<SelectListItem>();
            cates.ForEach(c =>
            {
                if (c.Id == id)
                {
                    Categories.Add(new SelectListItem { Value = c.Id.ToString(), Text = c.CategoryName, Selected = true });
                }
                else
                {
                    Categories.Add(new SelectListItem { Value = c.Id.ToString(), Text = c.CategoryName });
                }
            });
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var category = _mapper.Map<ComiCore.Model.Category>(InputModel);
            category.ModifiedDate = DateTime.Now;
            _unitOfWork.CategoryRepository.Edit(category);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}