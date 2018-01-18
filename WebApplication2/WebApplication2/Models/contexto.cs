using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication2.Models
{
    public class contexto: DbContext
    {
        public contexto() :
             base("contexto")
        {
        }
       

        public DbSet<credenciamento> credenciamentoes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

   

}