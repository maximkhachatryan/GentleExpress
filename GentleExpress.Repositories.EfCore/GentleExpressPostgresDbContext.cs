﻿using GentleExpress.Common.EfCore;
using GentleExpress.Repositories.Abstraction.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentleExpress.Repositories.EfCore;

public class GentleExpressPostgresDbContext : GentleExpressBaseDbContext
{
    public GentleExpressPostgresDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<City> Cities { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<ClientAddress> ClientAddresses { get; set; }
    public DbSet<ClientUser> ClientUsers { get; set; }
    public DbSet<Courier> Couriers { get; set; }
    public DbSet<District> Districts { get; set; }

}
