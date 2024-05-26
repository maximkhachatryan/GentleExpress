namespace GentleExpress.Models.Vendors;

public class VendorDTO
{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string BrandName { get; set; } = null!;
    public string? PhoneNumber1 { get; set; }
    public string? PhoneNumber2 { get; set; }
    public decimal VendorWalletAmount { get; set; }
}
