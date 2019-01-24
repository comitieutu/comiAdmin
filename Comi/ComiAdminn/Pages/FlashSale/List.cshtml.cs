using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiCore;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiAdminn.Pages.FlashSale
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
        public IList<FlashSaleModel> FlashSaleModels { get; set; }
        public class FlashSaleModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Description { get; set; }
            public int Sale { get; set; }
            public string Image { get; set; }
        }
        public void OnGet()
        {
            var flashSales = _unitOfWork.FlashSaleRepository.GetAll().ToList();
            FlashSaleModels = _mapper.Map<List<FlashSaleModel>>(flashSales);
        }
        public IActionResult OnGetDelete(int? id)
        {
            _unitOfWork.FlashSaleRepository.Delete(id);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}