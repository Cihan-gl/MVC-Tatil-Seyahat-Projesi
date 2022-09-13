using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aa.Model.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
}