using GentleExpress.Models.Orders;
using GentleExpress.Repositories.Abstraction.Entities;
using GentleExpress.Repositories.EfCore;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.EntityFrameworkCore;

namespace GentleExpress.Services.EFCore.Services;

public class DeliveriesService(GentleExpressPostgresDbContext context) : IDeliveriesService
{
    public async Task<OrderDTO> PlaceOrder(PlaceOrderRequest request)
    {
        var vendorAddress = await context.VendorAddresses
                .FirstOrDefaultAsync(a => a.Id == request.VendorAddressId);

        if (vendorAddress == null)
        {
            throw new Exception($"VendorAddress {request.VendorAddressId} not found");
        }

        var lastCode = await context.Deliveries
            .Where(o => o.VendorAddress == vendorAddress)
            .Select(o => o.DeliveryCode)
            .OrderByDescending(o => o)
            .Take(1)
            .FirstOrDefaultAsync();

        var order = new Delivery
        {
            ParcelDescription = request.ParcelDescription,
            VendorAddressId = vendorAddress.Id,
            DesiredPickUpDate = request.DesiredPickUpDate,
            ChargeDeliveryFee = request.ChargeDeliveryFee,
            ChargeParcelPrice = request.ChargeParcelPrice,
            ParcelPrice = request.ParcelPrice,
            VendorNotes = request.VendorNotes,
            DeliveryCode = lastCode + 1,
            CreateDate = DateTime.Now
        };

        var deliveryEntity = await context.Deliveries.AddAsync(order);

        await context.SaveChangesAsync();

        return new OrderDTO
        {
            Id = deliveryEntity.Entity.Id,
            //TODO
        };
    }

    public async Task FillOrder(int deliveryId, FillOrderRequest request)
    {
        var existingOrder = await context.Deliveries.FindAsync(deliveryId);
        if (existingOrder == null)
        {
            throw new Exception($"DeliveryId {deliveryId} not found");
        }

        existingOrder.ReceiverFillDate = DateTime.Now;
        existingOrder.ReceiverName = request.ReceiverName;
        existingOrder.ReceiverDistrictId = request.ReceiverDistrictId;
        existingOrder.ReceiverAddress = request.ReceiverAddress;
        existingOrder.ReceiverPhoneNumber = request.ReceiverPhoneNumber;
        existingOrder.ReceiverNotes = request.ReceiverNotes;

        await context.SaveChangesAsync();
    }
}
