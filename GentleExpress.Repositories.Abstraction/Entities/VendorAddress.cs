namespace GentleExpress.Repositories.Abstraction.Entities;

public class VendorAddress
{
    public int Id { get; set; }
    public string Address { get; set; } = null!;
    public bool IsRemoved { get; set; }


    public int DistrictId { get; set; }
    public District District { get; set; } = null!;

    public int VendorId { get; set; }
    public Vendor Vendor { get; set; } = null!;
}
