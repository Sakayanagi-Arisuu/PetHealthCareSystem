using System;
using System.Collections.Generic;

namespace PetHealthCareSystem.Repositories.Entities;

public partial class WorkSchedule
{
    public int ScheduleId { get; set; }

    public int? EmployeeId { get; set; }

    public int? VeterinarianId { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Veterinarian? Veterinarian { get; set; }
}
