using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Common;

namespace TravelTripProje.Models.Sınıflar
{
    public class Context : DbContext
    {
     

        //public Context(DbContextOptions<Context> options) : base(options) { }

      
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdreBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }

    }
}