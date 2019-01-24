using AutoMapper;
using ComiCore.Model;
using static ComiAdminn.Pages.FlashSale.EditModel;
using static ComiAdminn.Pages.FlashSale.ListModel;
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
            //product & productdetail
            CreateMap<Product, ProductModel>();
            CreateMap<CreateProduct, Product>();
            CreateMap<CreateProduct, ProductDetail>();
            CreateMap<EditProduct, Product>().ReverseMap();
            CreateMap<ProductDetail, ProductDetailModel>();
            //flashsale
            CreateMap<FlashSale, FlashSaleModel>();
            CreateMap<EditFlashSale, FlashSale>().ReverseMap();
        }
    }
}
