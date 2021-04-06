using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVVC_Forms.Models
{

    public class appDBContext:DbContext
    {
        public appDBContext(DbContextOptions<appDBContext>options):base(options)
        {

        }
        public DbSet<PersonModel> PersonModels{ get; set; }
    }
}
