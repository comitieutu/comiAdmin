using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComiAdminn.Pages.Product
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
        }
        public void OnGet()
        {
            var products = _unitOfWork.ProductRepository.GetAll().Where(p => p.Deleted == false)
                .Select(p => new ComiCore.Model.Product {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    ProductDes = p.ProductDes,
                    DesDetail = p.DesDetail,
                    Category = new ComiCore.Model.Category { Id = p.Category.Id, CategoryName = p.Category.CategoryName},
                    Brand = p.Brand,
                    Quantity = p.Quantity,
                    UnitPrice = p.UnitPrice
                })
                .ToList().OrderByDescending(p => p.Id);
            ProductModels = _mapper.Map<IList<ProductModel>>(products);
        }
        public IActionResult OnGetDelete(int id)
        {
            _unitOfWork.ProductRepository.Delete(id);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}