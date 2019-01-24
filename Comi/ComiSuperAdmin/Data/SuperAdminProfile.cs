using AutoMapper;
using ComiCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ComiSuperAdmin.Pages.Category.CreateModel;
using static ComiSuperAdmin.Pages.Category.DetailModel;
using static ComiSuperAdmin.Pages.Category.EditModel;
using static ComiSuperAdmin.Pages.Category.ListModel;
using static ComiSuperAdmin.Pages.Package.CreateModel;
using static ComiSuperAdmin.Pages.Package.EditModel;
using static ComiSuperAdmin.Pages.Package.ListModel;
using static ComiSuperAdmin.Pages.Payment.CreateModel;
using static ComiSuperAdmin.Pages.Payment.EditModel;
using static ComiSuperAdmin.Pages.Payment.ListModel;
using static ComiSuperAdmin.Pages.Product.DetailModel;
using static ComiSuperAdmin.Pages.Product.ListModel;
using static ComiSuperAdmin.Pages.Shipper.CreateModel;
using static ComiSuperAdmin.Pages.Shipper.EditModel;
using static ComiSuperAdmin.Pages.Shipper.ListModel;

namespace ComiSuperAdmin.Data
{
    public class SuperAdminProfile : Profile
    {
        public SuperAdminProfile()
        { 
            //category
            CreateMap<Category, CategoryModel>();
            CreateMap<CreateCategoryModel, Category>(); 
            CreateMap<EditCategory, Category>().ReverseMap();
            CreateMap<Category, CategoryDetailModel>();
            //payment
            CreateMap<CreatePayment, Payment>();
            CreateMap<Payment, PaymentModel>();
            CreateMap<EditPayment, Payment>().ReverseMap();
            //package
            CreateMap<Package, PackageModel>();
            CreateMap<CreatePackageModel, Package>();
            CreateMap<EditPackage, Package>().ReverseMap();
            //shipper
            CreateMap<Shipper, ShipperModel>();
            CreateMap<CreateShipperModel, Shipper>();
            CreateMap<EditShipperModel, Shipper>().ReverseMap();
            //product & productdetail
            CreateMap<Product, ProductModel>();
            CreateMap<ProductDetail, ProductDetailModel>();
        }
    }
}
