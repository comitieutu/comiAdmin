using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ComiAdminn.Pages.Product
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
        public EditProduct InputModel { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public class EditProduct
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public string ProductDes { get; set; }
            public int CategoryId { get; set; }
            public int Quantity { get; set; }
            public double UnitPrice { get; set; }
            public string Brand { get; set; }
            public string ProductImage { get; set; }
            public string DesDetail { get; set; }
        }
        public void OnGet(int id)
        {
            InputModel = _mapper.Map<EditProduct>(_unitOfWork.ProductRepository.Get(id));

            var cates = _unitOfWork.CategoryRepository.GetAll().Where(c => c.Parent != 0 && c.Deleted == false).ToList();
            Categories = new List<SelectListItem>();
            cates.ForEach(c => Categories.Add(new SelectListItem { Value = c.Id.ToString(), Text = c.CategoryName }));
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var product = _mapper.Map<ComiCore.Model.Product>(InputModel);
            product.ModifiedDate = DateTime.Now;
            _unitOfWork.ProductRepository.Edit(product);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}