using System;
using System.Collections.Generic;

namespace PetHealthCareSystem.Repositories.Entities;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? CustomerId { get; set; }

    public int? VeterinarianId { get; set; }

    public int? RoomId { get; set; }

    public int? PetId { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? BookingStatus { get; set; }

    public string? Notes { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Pet? Pet { get; set; }

    public virtual Room? Room { get; set; }

    public virtual Veterinarian? Veterinarian { get; set; }
}
