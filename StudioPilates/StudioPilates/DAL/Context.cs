using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudioPilates.DAL
{
    class Context : DbContext
    {
        public DbSet Alunos { get; set; }
    }

    
}
