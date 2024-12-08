using System;
using System.Collections.Generic;

namespace PetHealthCareSystem.Repositories.Entities;

public partial class Rating
{
    public int RatingId { get; set; }

    public int? CustomerId { get; set; }

    public int? ServiceId { get; set; }

    public byte? RatingScore { get; set; }

    public string? Comment { get; set; }

    public DateTime? RatingDate { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Service? Service { get; set; }
}
