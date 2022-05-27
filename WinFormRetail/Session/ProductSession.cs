using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormRetail.Model;

namespace WinFormRetail.Session
{
    static class ProductSession
    {
        public static Product Product { get; set; }
        public static void SetProduct(Product product)
        {
            Product = product;
        }
    }
}
