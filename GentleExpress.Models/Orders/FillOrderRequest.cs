namespace GentleExpress.Models.Orders;

public class FillOrderRequest
{
    public string ReceiverName { get; set; } = null!;
    public int ReceiverDistrictId { get; set; }
    public string ReceiverAddress { get; set; } = null!;
    public string ReceiverPhoneNumber { get; set; } = null!;
    public string? ReceiverNotes { get; set; }
}
