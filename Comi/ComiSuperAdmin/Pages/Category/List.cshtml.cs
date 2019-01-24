using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiService.Interfaces;
using ComiCore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ComiService.Helpers;

namespace ComiSuperAdmin.Pages.Category
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

        public string NameSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public PaginatedList<CategoryModel> CategoryModels { get; private set; }
        public class CategoryModel
        {
            public int Id { get; set; }
            public string CategoryName { get; set; }
            public string CategoryDes { get; set; }
            public int Parent { get; set; }
            public string ParentName { get; set; }
        }
        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            CurrentFilter = searchString;

            var categories = _unitOfWork.CategoryRepository.Entities;
            if (!String.IsNullOrEmpty(searchString))
            {
                categories = categories.Where(c => c.CategoryName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    categories = categories.OrderByDescending(s => s.CategoryName);
                    break;
                default:
                    categories = categories.OrderBy(s => s.CategoryName);
                    break;
            }

            int pageSize = 3;
            var cate = _mapper.Map<IEnumerable<CategoryModel>>(categories.AsNoTracking());
            CategoryModels = await PaginatedList<CategoryModel>.CreateAsync(cate.AsQueryable(), pageIndex ?? 1, pageSize);
            
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