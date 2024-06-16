namespace GentleExpress.Repositories.Abstraction.Entities;

public class Delivery
{
    public int Id { get; set; }

    //Vendor order
    public int DeliveryCode { get; set; }
    public string ParcelDescription { get; set; } = null!;
    public DateTime DesiredPickUpDate { get; set; }
    public bool ChargeDeliveryFee { get; set; }
    public bool ChargeParcelPrice { get; set; }
    public decimal? ParcelPrice { get; set; }
    public string? VendorNotes { get; set; }

    public int VendorAddressId { get; set; }
    public VendorAddress VendorAddress { get; set; } = null!;

    public DateTime CreateDate { get; set; }


    //Receiver order
    public DateTime ReceiverFillDate { get; set; }
    public string ReceiverName { get; set; } = null!;

    public int ReceiverDistrictId { get; set; }
    public District ReceiverDistrict { get; set; } = null!;

    public string ReceiverAddress { get; set; } = null!;
    public string ReceiverPhoneNumber { get; set; } = null!;
    public string? ReceiverNotes { get; set; }
}
