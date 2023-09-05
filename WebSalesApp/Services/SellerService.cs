using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesApp.Data;
using WebSalesApp.Models;

namespace WebSalesApp.Services
{
    public class SellerService
    {
        private readonly WebSalesAppContext _context;
        
        public SellerService(WebSalesAppContext context)
        {
            _context = context;
        }


        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}
