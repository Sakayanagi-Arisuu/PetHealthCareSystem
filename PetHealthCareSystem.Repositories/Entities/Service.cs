using System;
using System.Collections.Generic;

namespace PetHealthCareSystem.Repositories.Entities;

public partial class Service
{
    public int ServiceId { get; set; }

    public string? ServiceName { get; set; }

    public decimal? ServicePrice { get; set; }

    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();
}
