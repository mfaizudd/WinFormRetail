using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormRetail.Model
{
    public class Transaction
    {
        public string ID { get; set; }
        public DateTime Date { get; set; }
        public virtual User Users { get; set; }
    }
}
