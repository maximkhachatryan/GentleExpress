using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentleExpress.Repositories.Abstraction.Entities;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string BrandName { get; set; } = null!;
}
