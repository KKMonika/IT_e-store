using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace e_Store.Models
{
    public class eStoreDB: DbContext
    {
        public eStoreDB() : base("DefaultConnection") { }
        public static eStoreDB Create()
        {
            return new eStoreDB();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}