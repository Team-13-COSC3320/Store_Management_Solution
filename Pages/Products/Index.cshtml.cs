using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Store_Management.LibraryData.Models;
using Store_Management_Data;

namespace Store_Management
{
    public class IndexModel : PageModel
    {
        public IStore_Management_Asset storeRepo { get; }

        public IEnumerable<Product> Products { get; set;}

        public IndexModel(IStore_Management_Asset s)
        {
            storeRepo = s;
        }

        public void OnGet()
        {
            Products = storeRepo.GetAllProducts();
        }
    }
}