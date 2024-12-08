using System;
using System.Collections.Generic;

namespace PetHealthCareSystem.Repositories.Entities;

public partial class MedicalHistory
{
    public int MedicalHistoryId { get; set; }

    public int? PetId { get; set; }

    public int? VeterinarianId { get; set; }

    public DateOnly? VisitDate { get; set; }

    public string? Diagnosis { get; set; }

    public string? Treatment { get; set; }

    public virtual Pet? Pet { get; set; }

    public virtual Veterinarian? Veterinarian { get; set; }
}
