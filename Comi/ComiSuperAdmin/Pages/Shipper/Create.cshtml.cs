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
        public CreateShipperModel InputModel { get; set; }
        public class CreateShipperModel
        {
            public string Company { get; set; }
            public string ContactName { get; set; }
            public string ContactPhone { get; set; }
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
            var shipper = _mapper.Map<ComiCore.Model.Shipper>(InputModel);
            _unitOfWork.ShipperRepository.Create(shipper);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}