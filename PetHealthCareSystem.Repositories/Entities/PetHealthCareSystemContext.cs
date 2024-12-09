using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PetHealthCareSystem.Repositories.Entities;

public partial class PetHealthCareSystemContext : DbContext
{
    public PetHealthCareSystemContext()
    {
    }

    public PetHealthCareSystemContext(DbContextOptions<PetHealthCareSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<HealProcess> HealProcesses { get; set; }

    public virtual DbSet<MedicalHistory> MedicalHistories { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Pet> Pets { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Veterinarian> Veterinarians { get; set; }

    public virtual DbSet<WorkSchedule> WorkSchedules { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-6OVLRPL;Initial Catalog=PetHealthCareSystem;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__Account__349DA58687EB3AB9");

            entity.ToTable("Account");

            entity.HasIndex(e => e.Username, "UQ__Account__536C85E4BB2B54C3").IsUnique();

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Account__UserID__29572725");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__Booking__73951ACDF8288410");

            entity.ToTable("Booking");

            entity.Property(e => e.BookingId).HasColumnName("BookingID");
            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.BookingStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.PetId).HasColumnName("PetID");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.VeterinarianId).HasColumnName("VeterinarianID");

            entity.HasOne(d => d.Customer).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Booking__Custome__3D5E1FD2");

            entity.HasOne(d => d.Pet).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.PetId)
                .HasConstraintName("FK__Booking__PetID__403A8C7D");

            entity.HasOne(d => d.Room).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK__Booking__RoomID__3F466844");

            entity.HasOne(d => d.Veterinarian).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.VeterinarianId)
                .HasConstraintName("FK__Booking__Veterin__3E52440B");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B8AF766F72");

            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.LoyaltyPoints).HasDefaultValue(0);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Customers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Customer__UserID__2D27B809");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF154B702EF");

            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HireDate).HasColumnType("datetime");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Employees)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Employee__UserID__4CA06362");
        });

        modelBuilder.Entity<HealProcess>(entity =>
        {
            entity.HasKey(e => e.HealProcessId).HasName("PK__HealProc__0C0639D37E15D7A2");

            entity.ToTable("HealProcess");

            entity.Property(e => e.HealProcessId).HasColumnName("HealProcessID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.PetId).HasColumnName("PetID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VeterinarianId).HasColumnName("VeterinarianID");

            entity.HasOne(d => d.Pet).WithMany(p => p.HealProcesses)
                .HasForeignKey(d => d.PetId)
                .HasConstraintName("FK__HealProce__PetID__48CFD27E");

            entity.HasOne(d => d.Veterinarian).WithMany(p => p.HealProcesses)
                .HasForeignKey(d => d.VeterinarianId)
                .HasConstraintName("FK__HealProce__Veter__49C3F6B7");
        });

        modelBuilder.Entity<MedicalHistory>(entity =>
        {
            entity.HasKey(e => e.MedicalHistoryId).HasName("PK__MedicalH__3282CFA776FA3395");

            entity.ToTable("MedicalHistory");

            entity.Property(e => e.MedicalHistoryId).HasColumnName("MedicalHistoryID");
            entity.Property(e => e.Diagnosis).HasColumnType("text");
            entity.Property(e => e.PetId).HasColumnName("PetID");
            entity.Property(e => e.Treatment).HasColumnType("text");
            entity.Property(e => e.VeterinarianId).HasColumnName("VeterinarianID");
            entity.Property(e => e.VisitDate).HasColumnType("datetime");

            entity.HasOne(d => d.Pet).WithMany(p => p.MedicalHistories)
                .HasForeignKey(d => d.PetId)
                .HasConstraintName("FK__MedicalHi__PetID__534D60F1");

            entity.HasOne(d => d.Veterinarian).WithMany(p => p.MedicalHistories)
                .HasForeignKey(d => d.VeterinarianId)
                .HasConstraintName("FK__MedicalHi__Veter__5441852A");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payment__9B556A58896915F3");

            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.BookingId).HasColumnName("BookingID");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Booking).WithMany(p => p.Payments)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK__Payment__Booking__5812160E");
        });

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.PetId).HasName("PK__Pet__48E53802F4B00C57");

            entity.ToTable("Pet");

            entity.Property(e => e.PetId).HasColumnName("PetID");
            entity.Property(e => e.Breed)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HealthStatus).HasColumnType("text");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Species)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VaccinHistory).HasColumnType("text");
            entity.Property(e => e.Weight).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Customer).WithMany(p => p.Pets)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Pet__CustomerID__30F848ED");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.RatingId).HasName("PK__Rating__FCCDF85CD154E7F2");

            entity.ToTable("Rating");

            entity.Property(e => e.RatingId).HasColumnName("RatingID");
            entity.Property(e => e.Comment).HasColumnType("text");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.RatingDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

            entity.HasOne(d => d.Customer).WithMany(p => p.Ratings)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Rating__Customer__440B1D61");

            entity.HasOne(d => d.Service).WithMany(p => p.Ratings)
                .HasForeignKey(d => d.ServiceId)
                .HasConstraintName("FK__Rating__ServiceI__44FF419A");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__Room__3286391967DB45A3");

            entity.ToTable("Room");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.RoomType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__Service__C51BB0EA8D2C709E");

            entity.ToTable("Service");

            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ServicePrice).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CCACADD1F9FF");

            entity.ToTable("User");

            entity.HasIndex(e => e.Email, "UQ__User__A9D105344E5E56F0").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Address).HasColumnType("text");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Veterinarian>(entity =>
        {
            entity.HasKey(e => e.VeterinarianId).HasName("PK__Veterina__C97D02D81A678977");

            entity.ToTable("Veterinarian");

            entity.Property(e => e.VeterinarianId).HasColumnName("VeterinarianID");
            entity.Property(e => e.Availability).HasDefaultValue(true);
            entity.Property(e => e.Specialization)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Veterinarians)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Veterinar__UserI__34C8D9D1");
        });

        modelBuilder.Entity<WorkSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK__WorkSche__9C8A5B69EB1327AD");

            entity.ToTable("WorkSchedule");

            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.VeterinarianId).HasColumnName("VeterinarianID");

            entity.HasOne(d => d.Employee).WithMany(p => p.WorkSchedules)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__WorkSched__Emplo__4F7CD00D");

            entity.HasOne(d => d.Veterinarian).WithMany(p => p.WorkSchedules)
                .HasForeignKey(d => d.VeterinarianId)
                .HasConstraintName("FK__WorkSched__Veter__5070F446");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
