using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentleExpress.Common.EfCore;

public abstract class GentleExpressBaseDbContext : DbContext
{
    public GentleExpressBaseDbContext(DbContextOptions options) : base(options)
    {
    }
}
