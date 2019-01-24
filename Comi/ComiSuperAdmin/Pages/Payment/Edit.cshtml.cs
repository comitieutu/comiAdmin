using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;

namespace ComiSuperAdmin.Pages.Payment
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
        public EditPayment InputModel { get; set; }
        public class EditPayment
        {
            public int Id { get; set; }
            [Required]
            public string Name { get; set; }
            public string Description { get; set; }
        }
        public void OnGet(int id)
        {
            InputModel = _mapper.Map<EditPayment>(_unitOfWork.PaymentRepository.Get(id));
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var payment = _mapper.Map<ComiCore.Model.Payment>(InputModel);
            payment.ModifiedDate = DateTime.Now;
            _unitOfWork.PaymentRepository.Edit(payment);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}