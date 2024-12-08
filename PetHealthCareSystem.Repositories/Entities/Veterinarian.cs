using System;
using System.Collections.Generic;

namespace PetHealthCareSystem.Repositories.Entities;

public partial class Veterinarian
{
    public int VeterinarianId { get; set; }

    public int? UserId { get; set; }

    public string? Specialization { get; set; }

    public bool? Availability { get; set; }

    public int? YearsOfExperience { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<HealProcess> HealProcesses { get; set; } = new List<HealProcess>();

    public virtual ICollection<MedicalHistory> MedicalHistories { get; set; } = new List<MedicalHistory>();

    public virtual User? User { get; set; }

    public virtual ICollection<WorkSchedule> WorkSchedules { get; set; } = new List<WorkSchedule>();
}
