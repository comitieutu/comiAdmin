using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiCore;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiSuperAdmin.Pages.Product
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
        public IList<ProductModel> ProductModels { get; set; }
        public class ProductModel
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public string ProductDes { get; set; }
            public string DesDetail { get; set; }
            public ComiCore.Model.Category Category { get; set; }
            public string Brand { get; set; }
            public int Quantity { get; set; }
            public double UnitPrice { get; set; }
            public string UserId { get; set; }
            public string UserName { get; set; }
        }
        public void OnGet()
        {
            ProductModels = _unitOfWork.ProductRepository.GetAll().Include(p => p.User)
                .Select(p => new ProductModel
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    ProductDes = p.ProductDes,
                    DesDetail = p.DesDetail,
                    Category = new ComiCore.Model.Category { Id = p.Category.Id, CategoryName = p.Category.CategoryName},
                    Brand = p.Brand,
                    Quantity = p.Quantity,
                    UnitPrice = p.UnitPrice,
                    UserId = p.UserId,
                    UserName = p.User.UserName
                })
                .OrderByDescending(p => p.Id).ToList();
        }
    }
}