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
        public EditShipperModel InputModel { get; set; }
        public class EditShipperModel
        {
            public int Id { get; set; }
            public string Company { get; set; }
            public string ContactName { get; set; }
            public string ContactPhone { get; set; }
        }
        public void OnGet(int id)
        {
            InputModel = _mapper.Map<EditShipperModel>(_unitOfWork.ShipperRepository.Get(id));
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var shipper = _mapper.Map<ComiCore.Model.Shipper>(InputModel);
            shipper.ModifiedDate = DateTime.Now;
            _unitOfWork.ShipperRepository.Edit(shipper);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}