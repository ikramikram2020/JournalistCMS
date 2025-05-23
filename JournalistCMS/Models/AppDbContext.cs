using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;




namespace JournalistCMS.Models
    {
        public class AppDbContext : DbContext
        {
            public DbSet<Journalist> Journalists { get; set; }
            public DbSet<Article> Articles { get; set; }


    }
}

