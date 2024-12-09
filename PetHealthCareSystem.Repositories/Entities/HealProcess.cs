using System;
using System.Collections.Generic;

namespace PetHealthCareSystem.Repositories.Entities;

public partial class HealProcess
{
    public int HealProcessId { get; set; }

    public int? PetId { get; set; }

    public int? VeterinarianId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Status { get; set; }

    public string? Notes { get; set; }

    public virtual Pet? Pet { get; set; }

    public virtual Veterinarian? Veterinarian { get; set; }
}
