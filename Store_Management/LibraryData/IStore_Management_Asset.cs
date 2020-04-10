using System;
using System.Collections.Generic;
using System.Text;
using LibraryData.Models;
using Store_Management.LibraryData.Models;

namespace Store_Management_Data
{
    public interface IStore_Management_Asset
    {
        IEnumerable<Review> GetAllReviews();
        IEnumerable<User> GetAllUsers();
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
        List<Review> GetReviewsOnProduct(int id); //id = P_ID

    }
}
