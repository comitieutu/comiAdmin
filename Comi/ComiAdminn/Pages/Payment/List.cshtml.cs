using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace ComiAdminn.Pages.Payment
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
        public IList<PaymentModel> PaymentModels { get; set; }
        public class PaymentModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
        public void OnGet()
        {
            PaymentModels = _mapper.Map<IList<PaymentModel>>(_unitOfWork.PaymentRepository.GetAll().Where(p => p.Deleted == false).ToList().OrderByDescending(p => p.Id));
        }
        public IActionResult OnGetDelete(int id)
        {
            _unitOfWork.PaymentRepository.Delete(id);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}