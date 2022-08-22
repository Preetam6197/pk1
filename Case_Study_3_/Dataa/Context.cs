using Case_Study_3_.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_Study_3_.Dataa
{
    public class Context : DbContext
    {


        public Context(DbContextOptions<Context> options) : base(options)
        {

        }


        public DbSet<School> ss { get; set; }

        

    }
}
