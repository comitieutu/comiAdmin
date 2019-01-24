using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiSuperAdmin.Pages.Product
{
    public class DetailModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DetailModel(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IList<ProductDetailModel> ProductDetails { get; set; }
        public class ProductDetailModel
        {
            public int Id { get; set; }
            public int ProductId { get; set; }
            public string Name { get; set; }
            public string ProductImage { get; set; }
        }
        public void OnGet(int id)
        {
            var details = _unitOfWork.ProductDetailRepository.GetAll().Where(p => p.ProductId == id).ToList();
            ProductDetails = _mapper.Map<IList<ProductDetailModel>>(details);
            ProductDetails.ToList().ForEach(p => p.Name = _unitOfWork.ProductRepository.Get(id).ProductName);
        }
    }
}