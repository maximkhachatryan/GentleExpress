using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentleExpress.Repositories.Abstraction.Entities;

public class ClientAddress
{
    public int Id { get; set; }
    public string Address { get; set; } = null!;

    public int DistrictId { get; set; }
    public District District { get; set; } = null!;

    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;
}
