﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<SiteDb>(new SiteDbInitialize());
            using (var myContext = new SiteDb())
            {
                var x = myContext.Presidents.ToList();
            }
        }
    }

    public class SiteDb : DbContext
    {
        public SiteDb() : base("DefaultConnection")
        {
            
        }
        public DbSet<President> Presidents { get; set; }
    }
    public class President
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string LastName { get; set; }
        public int YearElected { get; set; }
        public bool CurrentPresident { get; set; }
        public string Party { get; set; }
    }

    public class SiteDbInitialize :
        CreateDatabaseIfNotExists<SiteDb>
    {
        protected override void Seed(SiteDb context)
        {
            context.Presidents.Add(new President {LastName = "Lincoln", YearElected = 1809, CurrentPresident = false});
            context.Presidents.Add(new President {LastName = "Bush", YearElected = 1992, CurrentPresident = false });
            context.Presidents.Add(new President { LastName = "Obama", YearElected = 2008, CurrentPresident = false });
        }
    }
}

