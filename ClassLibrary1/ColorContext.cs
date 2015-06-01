using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClassLibrary1
{
    public class ColorContext: DbContext
    {
        public ColorContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Color> Colors { get; set; }
    }
}