namespace GentleExpress.Repositories.Abstraction.Entities;

public class Vendor
{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string BrandName { get; set; } = null!;
    public string? PhoneNumber1 { get; set; }
    public string? PhoneNumber2 { get; set; }
    public decimal VendorWalletAmount { get; set; }
    public ICollection<VendorAddress> Addresses { get; set; } = null!;
}
