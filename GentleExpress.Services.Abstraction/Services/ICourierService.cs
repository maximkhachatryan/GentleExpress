using GentleExpress.Models.Couriers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentleExpress.Services.Abstraction.Services;

public interface ICourierService
{
    Task<List<CourierDTO>> GetCouriers();
}
