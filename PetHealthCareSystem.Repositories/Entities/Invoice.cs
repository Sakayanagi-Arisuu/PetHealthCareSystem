using System;
using System.Collections.Generic;

namespace PetHealthCareSystem.Repositories.Entities;

public partial class Invoice
{
    public int InvoiceId { get; set; }

    public int BookingId { get; set; }

    public decimal TotalAmount { get; set; }

    public string? PaymentStatus { get; set; }

    public DateTime? PaymentDate { get; set; }

    public virtual Booking Booking { get; set; } = null!;
}
