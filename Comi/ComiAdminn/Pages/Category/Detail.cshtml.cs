using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComiAdminn.Pages.Category
{
    public class DetailModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DetailModel(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public CategoryDetailModel CategoryDetail { get; set; }
        public class CategoryDetailModel
        {
            public int Id { get; set; }
            public string CategoryName { get; set; }
            public string CategoryDes { get; set; }
            public int Parent { get; set; }
            public string ParentName { get; set; }
        }
        public void OnGet(int id)
        {
            var category = _unitOfWork.CategoryRepository.Get(id);
            CategoryDetail = _mapper.Map<CategoryDetailModel>(category);
            if (category.Parent != 0)
            {
                CategoryDetail.ParentName = _unitOfWork.CategoryRepository.Get(category.Parent).CategoryName;
            }
            else
            {
                CategoryDetail.ParentName = category.CategoryName;
            }
        }
        public IActionResult OnGetDelete(int id)
        {
            _unitOfWork.CategoryRepository.Delete(id);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}