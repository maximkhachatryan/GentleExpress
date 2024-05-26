using System.Numerics;

namespace GentleExpress.Models.VendorAddresses;

public class VendorAddressDTO
{
    public int Id { get; set; }
    public string Address { get; set; } = null!;
    public int DistrictId { get; set; }
}
