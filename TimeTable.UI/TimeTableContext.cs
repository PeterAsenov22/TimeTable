namespace TimeTable.UI
{
    using Microsoft.EntityFrameworkCore;
    using TimeTable.UI.Models;

    public partial class TimeTableContext : DbContext
    {
        public TimeTableContext()
        {
        }

        public TimeTableContext(DbContextOptions<TimeTableContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectHours> ProjectHours { get; set; }
        public virtual DbSet<ProjectMonths> ProjectMonths { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=TimeTable;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("EMPLOYEES");

                entity.HasIndex(e => e.EmployeeEgn)
                    .HasName("IDX_EMPLOYEE_UQ")
                    .IsUnique();

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EMPLOYEE_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmployeeEgn)
                    .IsRequired()
                    .HasColumnName("EMPLOYEE_EGN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeHiredate)
                    .HasColumnName("EMPLOYEE_HIREDATE")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeLastname)
                    .IsRequired()
                    .HasColumnName("EMPLOYEE_LASTNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasColumnName("EMPLOYEE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeePosition)
                    .HasColumnName("EMPLOYEE_POSITION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeSurname)
                    .IsRequired()
                    .HasColumnName("EMPLOYEE_SURNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("PROJECT");

                entity.HasIndex(e => e.ProjectName)
                    .HasName("IDX_PROJECT_UQ")
                    .IsUnique();

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProjectBegin)
                    .HasColumnName("PROJECT_BEGIN")
                    .HasColumnType("date");

                entity.Property(e => e.ProjectDescription)
                    .HasColumnName("PROJECT_DESCRIPTION")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectEnd)
                    .HasColumnName("PROJECT_END")
                    .HasColumnType("date");

                entity.Property(e => e.ProjectMaxhours)
                    .HasColumnName("PROJECT_MAXHOURS")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("PROJECT_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectStatus)
                    .IsRequired()
                    .HasColumnName("PROJECT_STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProjectHours>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.EmployeeId, e.ProjectTaskdate });

                entity.ToTable("PROJECT_HOURS");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EMPLOYEE_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProjectTaskdate)
                    .HasColumnName("PROJECT_TASKDATE")
                    .HasColumnType("date");

                entity.Property(e => e.ProjectHours1)
                    .HasColumnName("PROJECT_HOURS")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProjectMonthId)
                    .HasColumnName("PROJECT_MONTH_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProjectTask)
                    .IsRequired()
                    .HasColumnName("PROJECT_TASK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ProjectHours)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROJECT__REFERENCE_EMPLOYEE");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectHours)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROJECT__REFERENCE_PROJECT1");

                entity.HasOne(d => d.ProjectMonth)
                    .WithMany(p => p.ProjectHours)
                    .HasForeignKey(d => d.ProjectMonthId)
                    .HasConstraintName("FK_PROJECT__REFERENCE_PROJECT_");
            });

            modelBuilder.Entity<ProjectMonths>(entity =>
            {
                entity.HasKey(e => e.ProjectMonthId);

                entity.ToTable("PROJECT_MONTHS");

                entity.HasIndex(e => new { e.ProjectId, e.ProjectYear, e.ProjectMonth })
                    .HasName("IDX_PROJECT_MONTHS_UQ")
                    .IsUnique();

                entity.Property(e => e.ProjectMonthId)
                    .HasColumnName("PROJECT_MONTH_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProjectMonth)
                    .HasColumnName("PROJECT_MONTH")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProjectMonthStatus)
                    .IsRequired()
                    .HasColumnName("PROJECT_MONTH_STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.ProjectYear)
                    .HasColumnName("PROJECT_YEAR")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectMonths)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROJECT__REFERENCE_PROJECT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
