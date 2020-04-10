using LibraryData.Models;
using Store_Management.LibraryData.Models;
using Store_Management_Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Management_Services
{
    public class MockProductList : IStore_Management_Asset
    {
        private List<Product> _productList;
        private List<Review> _reviewList;
        public MockProductList()
        {
            _productList = new List<Product>()
            {
                new Product() { P_ID = 1, P_Name = "Car1", P_Category="Fast Car", P_Price=100000, P_Description = "This car can go 150 mph", photoPath = "/images/space car 2.jpg"},
                new Product() { P_ID = 2, P_Name = "Car2", P_Category="Slow Car", P_Price=50000, P_Description = "This car can go 80 mph", photoPath = "/images/space car 1.jpg"}
            };

            _reviewList = new List<Review>()
            {
                new Review() { R_ID = 1, R_Title = "Car was really fast", R_Content = "I loved this car very much! I have two of them!", R_Star = 5, R_UID = 1, P_ID = 1 },
                 new Review() { R_ID = 2, R_Title = "Car was really slow", R_Content = "Not a good bang for your buck", R_Star = 2, R_UID = 1, P_ID = 2 },
                  new Review() { R_ID = 3, R_Title = "Car was Just right", R_Content = "I liked the price", R_Star = 4, R_UID = 2, P_ID = 2 }
            };
        }



        public IEnumerable<Product> GetAllProducts()
        {
            return _productList;
        }

        public Product GetProduct(int id)
        {
            return _productList.FirstOrDefault(p => p.P_ID == id);
        }

        public List<Review> GetReviewsOnProduct(int id)
        {
            //need to return a list of all the reviews
            List<Review> validReviews = new List<Review>();
            foreach(Review r in _reviewList)
            {
                if(r.P_ID == id)
                {
                    validReviews.Add(r);
                }
            }

            return validReviews;
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
