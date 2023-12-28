﻿

using Products_WebApi_app.Models;

namespace Products_WebApi_app.Repository
{
    public interface IProductRepository
    {
        // private List<Product> products = new List<Product>();
        List<Product> GetProducts();
        Product GetProductById(int productId);
        List<Product> GetProductByName(string productName);
        Product AddProduct(Product product);
        Product UpdateProduct(int productId, Product updatedProduct);
        string DeleteProduct(int productId);




    }
}
