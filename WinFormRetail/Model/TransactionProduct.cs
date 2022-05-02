using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormRetail.Model
{
    public  class TransactionProduct
    {
        public int ID { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
