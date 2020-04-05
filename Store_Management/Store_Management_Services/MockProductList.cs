using LibraryData.Models;
using Store_Management.LibraryData.Models;
using Store_Management_Data;
using System;
using System.Collections.Generic;

namespace Store_Management_Services
{
    public class MockProductList : IStore_Management_Asset
    {
        private List<Product> _productList;

        public MockProductList()
        {
            _productList = new List<Product>()
            {
                new Product() { P_ID = 1, P_Name = "Car1", P_Category="Fast Car", P_Price=100000, P_Description = "This car can go 150 mph", photoPath = "/images/space car 2.jpg"},
                new Product() { P_ID = 2, P_Name = "Car2", P_Category="Slow Car", P_Price=50000, P_Description = "This car can go 80 mph", photoPath = "/images/space car 1.jpg"}
            };
        }


        public IEnumerable<Product> GetAllProducts()
        {
            return _productList;
        }

        public IEnumerable<Review> GetAllReviews()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
