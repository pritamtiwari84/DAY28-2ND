
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products_WebApi_app.Models;

namespace Products_WebApi_app.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products;

        public ProductRepository()
        {
            // Initialize with some sample data
            products = new List<Product>
        {
            new Product { ProductId = 1, ProductName = "Smartphone", ProductBrand = "Vivo", ProductQuantity = 1, ProductPrice = 10000 },
            new Product { ProductId = 2, ProductName = "Laptop", ProductBrand ="Hp", ProductQuantity = 2, ProductPrice = 5000 }
        };
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(p => p.ProductId == productId);
        }

        public List<Product> GetProductByName(string productName)
        {
            return products.Where(p => p.ProductName.Contains(productName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Product AddProduct(Product product)
        {
            product.ProductId = products.Count + 1;
            products.Add(product);
            return product;

        }

        public Product UpdateProduct(int productId, Product updatedProduct)
        {
            var existingProduct = products.FirstOrDefault(p => p.ProductId == productId);
            if (existingProduct != null)
            {
                existingProduct.ProductName = updatedProduct.ProductName;
                existingProduct.ProductBrand = updatedProduct.ProductBrand;
                existingProduct.ProductQuantity = updatedProduct.ProductQuantity;
                existingProduct.ProductPrice = updatedProduct.ProductPrice;
                return existingProduct;
            }
            return null;
        }

        public string DeleteProduct(int productId)
        {
            var productToRemove = products.FirstOrDefault(p => p.ProductId == productId);
            if (productToRemove != null)
            {
                products.Remove(productToRemove);
                return productToRemove.ProductName;
            }
            return null;
        }

    }
}
        
