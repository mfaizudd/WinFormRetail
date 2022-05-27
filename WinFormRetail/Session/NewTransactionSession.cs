using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormRetail.Session
{
    public class NewTransactionSession
    {
        public string ID { get; set; }
        public string Product { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Subtotal { get; set; }
    }
}
