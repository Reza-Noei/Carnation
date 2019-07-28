using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class Context : DbContext
    {     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=REZA-PC\SQL2014;Initial Catalog=StoreDB;user id=Admin;password=7277978;MultipleActiveResultSets=True;");
        }
    }
}
