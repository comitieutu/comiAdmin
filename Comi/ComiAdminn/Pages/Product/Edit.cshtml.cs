using System;
using System.Threading.Tasks;
using AutoMapper;
using ComiCore;
using ComiService.Common;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ComiAdminn.Pages.Product
{
    public class EditModel : CategoryPageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public EditModel(IUnitOfWork unitOfWork, IMapper mapper, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
            _userManager = userManager;
        }
        [BindProperty]
        public EditProduct InputModel { get; set; }
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

            CategoryDropDownList(_context, id);
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var product = _mapper.Map<ComiCore.Model.Product>(InputModel);
            product.ModifiedDate = DateTime.Now;
            product.User = await _userManager.GetUserAsync(User);
            _unitOfWork.ProductRepository.Edit(product);
            _unitOfWork.Commit();
            return RedirectToPage("./List");
        }
    }
}