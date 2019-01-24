using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComiSuperAdmin.Pages.Shipper
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
        public IList<ShipperModel> ShipperModels { get; set; }
        public class ShipperModel
        {
            public int Id { get; set; }
            public string Company { get; set; }
            public string ContactName { get; set; }
            public string ContactPhone { get; set; }
        }
        public void OnGet()
        {
            var shippers = _unitOfWork.ShipperRepository.GetAll().ToList();
            ShipperModels = _mapper.Map<List<ShipperModel>>(shippers);
        }
        public IActionResult OnGetDelete(int? id)
        {
            _unitOfWork.ShipperRepository.Delete(id);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}