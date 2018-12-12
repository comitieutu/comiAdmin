using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiService.Interfaces;
using ComiCore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoMapper;

namespace ComiAdminn.Pages.Category
{
    public class ListModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ListModel(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IList<CategoryModel> CategoryModels { get; private set; }
        public class CategoryModel
        {
            public int Id { get; set; }
            public string CategoryName { get; set; }
            public string CategoryDes { get; set; }
            public int Parent { get; set; }
            public string ParentName { get; set; }
        }
        public void OnGet()
        {
            var categories = _unitOfWork.CategoryRepository.GetAll().Where(c => c.Deleted == false).ToList().OrderByDescending(c => c.Id);
            CategoryModels = _mapper.Map<IList<CategoryModel>>(categories);
            CategoryModels.ToList().ForEach(c =>
            {
                if (c.Parent != 0)
                {
                    c.ParentName = _unitOfWork.CategoryRepository.Get(c.Parent).CategoryName;
                }
                else
                {
                    c.ParentName = c.CategoryName;
                }
            });
        }
        public IActionResult OnGetDelete(int id)
        {
            _unitOfWork.CategoryRepository.Delete(id);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}