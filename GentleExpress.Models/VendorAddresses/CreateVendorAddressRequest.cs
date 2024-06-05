namespace GentleExpress.Models.Vendors;

public class CreateVendorAddressRequest
{
    public int DistrictId { get; set; }
    public string Address { get; set; } = null!;
}
