using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComiSuperAdmin.Pages.Payment
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
        public CreatePayment InputModel { get; set; }
        public class CreatePayment
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var payment = _mapper.Map<ComiCore.Model.Payment>(InputModel);
                _unitOfWork.PaymentRepository.Create(payment);
                _unitOfWork.Commit();
                return RedirectToPage("./List");
            }
            return Page();
        }
    }
}