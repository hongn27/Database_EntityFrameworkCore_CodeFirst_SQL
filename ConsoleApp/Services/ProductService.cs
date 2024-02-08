using ConsoleApp.Entities;
using ConsoleApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services;

    internal class ProductService
    {
        private readonly ProductRepository _productRepository;
        private readonly CategoryService _categoryService;
        private readonly ManufactureService _manufactureService;

        public ProductService(ProductRepository productRepository, CategoryService categoryService, ManufactureService manufactureService)
        {
            _productRepository = productRepository;
            _categoryService = categoryService;
            _manufactureService = manufactureService;
        }

        public ProductEntity CreateProduct(int articleNumber, string title, string Ingress, string description, decimal price, string manufactureName, string categoryName)
        {
            var categoryEntity = _categoryService.CreateCategory(categoryName);
            var manufactureEntity = _manufactureService.CreateManufacture(manufactureName);
        
            var productEntity = new ProductEntity
            {
                ArticleNumber = articleNumber,
                Title = title,
                Ingress = Ingress,
                Description = description,
                Price = price,
                ManufactureID = manufactureEntity.Id,
                CategoryID = categoryEntity.Id,
            };

            productEntity = _productRepository.Create(productEntity);
            return productEntity;
        }


        public ProductEntity GetProductById(int id)
        {
            var productEntity = _productRepository.Get(x => x.Id == id);
            return productEntity;
        }

        public IEnumerable<ProductEntity> GetProduct()
        {
            var products = _productRepository.GetAll();
            return products;
        }

        public ProductEntity UpdateProduct(ProductEntity productEntity)
        {
            var updatedProductEntity = _productRepository.Update(x => x.Id == productEntity.Id, productEntity);
            return updatedProductEntity;
        }

        public void DeleteProduct(int id)
        {
            _productRepository.Detele(x => x.Id == id);
        }

    }
