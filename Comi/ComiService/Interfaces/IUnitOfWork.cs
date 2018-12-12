using ComiCore.Model;

namespace ComiService.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Product> ProductRepository { get; }
        IRepository<Category> CategoryRepository { get; }
        IRepository<PersonInfo> PersonInfoRepository { get; }
        IRepository<ProductDetail> ProductDetailRepository { get; }
        IRepository<ReceiveProduct> ReceiveProductRepository { get; }
        IRepository<SaleOrder> SaleOrderRepository { get; }
        IRepository<SaleOrderDetail> SaleOrderDetailRepository { get; }
        IRepository<Shipper> ShipperRepository { get; }
        IRepository<Comment> CommentRepository { get; }
        IRepository<Payment> PaymentRepository { get; }
        IRepository<Package> PackageRepository { get; }
        void Refresh();
        void Commit();
    }
}
