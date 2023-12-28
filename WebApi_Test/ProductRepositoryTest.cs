using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products_WebApi_app.Models;
using Products_WebApi_app.Repository;

namespace WebApi_Test.Repository
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void GetProductById_ProductFound_ReturnsProduct()
        {
            // Arrange
            var repository = new ProductRepository();
            int productId = 1;

            // Act
            var product = repository.GetProductById(productId);

            // Assert
            Assert.NotNull(product);
            Assert.Equal(productId, product.ProductId);
        }

        [Fact]
        public void AddProduct_ValidProduct_ReturnsAddedProduct()
        {
            // Arrange
            var repository = new ProductRepository();
            var newProduct = new Product
            {
                ProductName = "Freez",
                ProductBrand = "Samsung",
                ProductQuantity = 5,
                ProductPrice = 30000
            };

            // Act
            var addedProduct = repository.AddProduct(newProduct);

            // Assert
            Assert.NotNull(addedProduct);
            Assert.Equal(newProduct.ProductName, addedProduct.ProductName);
            Assert.Equal(newProduct.ProductBrand, addedProduct.ProductBrand);
            Assert.Equal(newProduct.ProductQuantity, addedProduct.ProductQuantity);
            Assert.Equal(newProduct.ProductPrice, addedProduct.ProductPrice);
        }

        [Fact]
        public void UpdateProduct_ValidIdAndProduct_ReturnsUpdatedProduct()
        {
            // Arrange
            var repository = new ProductRepository();
            int productId = 1;
            var updatedProduct = new Product
            {
                ProductName = "Washing Machine",
                ProductBrand = "LG",
                ProductQuantity = 8,
                ProductPrice = 70000
            };

            // Act
            var result = repository.UpdateProduct(productId, updatedProduct);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(productId, result.ProductId);
            Assert.Equal(updatedProduct.ProductName, result.ProductName);
            Assert.Equal(updatedProduct.ProductBrand, result.ProductBrand);
            Assert.Equal(updatedProduct.ProductQuantity, result.ProductQuantity);
            Assert.Equal(updatedProduct.ProductPrice, result.ProductPrice);
        }

        [Fact]
        public void DeleteProduct_ValidId_ReturnsDeletedProductName()
        {
            // Arrange
            var repository = new ProductRepository();
            int productId = 1;

            // Act
            var deletedProductName = repository.DeleteProduct(productId);

            // Assert
            Assert.NotNull(deletedProductName);
            Assert.Equal("Smartphone", deletedProductName); // Assuming the sample data contains a product with the name "Laptop"
        }

    }
}
    

