using AutoMapper;
using ComiCore.Model;
using static ComiAdminn.Pages.Category.CreateModel;
using static ComiAdminn.Pages.Category.DetailModel;
using static ComiAdminn.Pages.Category.EditModel;
using static ComiAdminn.Pages.Category.ListModel;
using static ComiAdminn.Pages.Package.CreateModel;
using static ComiAdminn.Pages.Package.EditModel;
using static ComiAdminn.Pages.Package.ListModel;
using static ComiAdminn.Pages.Payment.CreateModel;
using static ComiAdminn.Pages.Payment.EditModel;
using static ComiAdminn.Pages.Payment.ListModel;
using static ComiAdminn.Pages.Product.CreateModel;
using static ComiAdminn.Pages.Product.DetailModel;
using static ComiAdminn.Pages.Product.EditModel;
using static ComiAdminn.Pages.Product.EditPhotoModel;
using static ComiAdminn.Pages.Product.ListModel;

namespace ComiAdminn.Data
{
    public class ComiProfile : Profile
    {

        public ComiProfile()
        {
            //category
            CreateMap<Category, CategoryModel>();
            CreateMap<CreateCategoryModel, Category>(); 
            CreateMap<EditCategory, Category>();
            CreateMap<Category, CategoryDetailModel>();
            //payment
            CreateMap<CreatePayment, Payment>();
            CreateMap<Payment, PaymentModel>();
            CreateMap<EditPayment, Payment>();
            //package
            CreateMap<Package, PackageModel>();
            CreateMap<CreatePackageModel, Package>();
            CreateMap<EditPackage, Package>();
            //product & productdetail
            CreateMap<Product, ProductModel>();
            CreateMap<CreateProduct, Product>();
            CreateMap<CreateProduct, ProductDetail>();
            CreateMap<EditProduct, Product>().ReverseMap();
            CreateMap<ProductDetail, ProductDetailModel>();
        }
    }
}
