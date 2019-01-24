using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComiSuperAdmin.Pages.Package
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
        public IList<PackageModel> PackageModels { get; private set; }
        public class PackageModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }
        }
        public void OnGet()
        {
            var packages = _unitOfWork.PackageRepository.GetAll().ToList().OrderByDescending(p => p.Id);
            PackageModels = _mapper.Map<IList<PackageModel>>(packages);
        }
        public IActionResult OnGetDelete(int id)
        {
            _unitOfWork.PackageRepository.Delete(id);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}