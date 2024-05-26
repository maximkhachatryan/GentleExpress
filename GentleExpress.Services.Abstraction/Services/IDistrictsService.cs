using GentleExpress.Models.Districts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentleExpress.Services.Abstraction.Services;

public interface IDistrictsService
{
    Task<List<DistrictDTO>> GetDistrictsByCityId(int cityId);
}
