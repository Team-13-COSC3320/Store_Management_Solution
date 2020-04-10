using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Store_Management.LibraryData.Models;
using Store_Management_Data;

namespace Store_Management
{
    public class DetailsModel : PageModel
    {
        public DetailsModel(IStore_Management_Asset detailRepo)
        {
            DetailRepo = detailRepo;
        }

        public IStore_Management_Asset DetailRepo { get; }

        public Product Product { get; private set; }

        public List<Review> validReviews { get; private set; }

        public void OnGet(int id)
        {
            Product = DetailRepo.GetProduct(id);
            validReviews = DetailRepo.GetReviewsOnProduct(id);
        }
    }
}