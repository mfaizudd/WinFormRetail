using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormRetail.Model;

namespace WinFormRetail.Data
{
    public class CashireDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Model.Transaction> Transactions { get; set; }
        public DbSet<TransactionProduct> TransactionProducts { get; set; }

        public string DbPath { get; }

        public CashireDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            Console.WriteLine(path);
            DbPath = Path.Join(path, "cashier.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
            => options.UseSqlite($"Data Source={DbPath}");
        
    }
}
