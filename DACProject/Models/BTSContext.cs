using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DACProject.Models
{
    public class BTSContext:DbContext
    {
        public BTSContext(DbContextOptions<BTSContext> options):base(options)
        {

        }
    }
}
