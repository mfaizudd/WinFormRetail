using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormRetail.Model
{
    public class Transaction
    {
        public int ID { get; set; }
        public string TransactionId { get; set; }
        public DateTime Date { get; set; }
        public virtual User Users { get; set; }
    }
}
