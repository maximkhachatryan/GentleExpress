﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentleExpress.Repositories.Abstraction.Entities;

public class District
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public int CityId { get; set; }
    public City City { get; set; } = null!;
}
