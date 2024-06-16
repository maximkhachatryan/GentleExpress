namespace GentleExpress.Models.Orders;

public class PlaceOrderRequest
{
    public string ParcelDescription { get; set; } = null!;
    public DateTime DesiredPickUpDate { get; set; }
    public bool ChargeDeliveryFee { get; set; }
    public bool ChargeParcelPrice { get; set; }
    public decimal? ParcelPrice { get; set; }
    public string? VendorNotes { get; set; }

    public int VendorAddressId { get; set; }

    public DateTime CreateDate { get; set; }
}
