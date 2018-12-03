﻿using ComiCore;
using ComiCore.Model;
using ComiService.Interfaces;

namespace ComiService.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private IRepository<Product> _productRepository;
        private IRepository<Category> _categoryRepository;
        private IRepository<PersonInfo> _personInfoRepository;
        private IRepository<ProductDetail> _productDetailRepository;
        private IRepository<ReceiveProduct> _receiveProductRepository;
        private IRepository<SaleOrder> _saleOrderRepository;
        private IRepository<SaleOrderDetail> _saleOrderDetailRepository;
        private IRepository<Shipper> _shipperRepository;
        private IRepository<Comment> _commentRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IRepository<Product> ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new Repository<Product>(_context);
                }
                return _productRepository;
            }
        }
        public IRepository<Category> CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new Repository<Category>(_context);
                }
                return _categoryRepository;
            }
        }

        public IRepository<PersonInfo> PersonInfoRepository
        {
            get
            {
                if (_personInfoRepository == null)
                {
                    _personInfoRepository = new Repository<PersonInfo>(_context);
                }
                return _personInfoRepository;
            }
        }

        public IRepository<ProductDetail> ProductDetailRepository
        {
            get
            {
                if (_productDetailRepository == null)
                {
                    _productDetailRepository = new Repository<ProductDetail>(_context);
                }
                return _productDetailRepository;
            }
        }

        public IRepository<ReceiveProduct> ReceiveProductRepository
        {
            get
            {
                if (_receiveProductRepository == null)
                {
                    _receiveProductRepository = new Repository<ReceiveProduct>(_context);
                }
                return _receiveProductRepository;
            }
        }

        public IRepository<SaleOrder> SaleOrderRepository
        {
            get
            {
                if (_saleOrderRepository == null)
                {
                    _saleOrderRepository = new Repository<SaleOrder>(_context);
                }
                return _saleOrderRepository;
            }
        }

        public IRepository<SaleOrderDetail> SaleOrderDetailRepository
        {
            get
            {
                if (_saleOrderDetailRepository == null)
                {
                    _saleOrderDetailRepository = new Repository<SaleOrderDetail>(_context);
                }
                return _saleOrderDetailRepository;
            }
        }

        public IRepository<Shipper> ShipperRepository
        {
            get
            {
                if (_shipperRepository == null)
                {
                    _shipperRepository = new Repository<Shipper>(_context);
                }
                return _shipperRepository;
            }
        }

        public IRepository<Comment> CommentRepository
        {
            get
            {
                if (_commentRepository == null)
                {
                    _commentRepository = new Repository<Comment>(_context);
                }
                return _commentRepository;
            }
        }

        public void Refresh()
        {
            _context.Rollback();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
