using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataEntity;

public partial class CrudContext : DbContext
{
    public CrudContext()
    {
    }

    public CrudContext(DbContextOptions<CrudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CityDetail> CityDetails { get; set; }

    public virtual DbSet<EmployeeTbl> EmployeeTbls { get; set; }

    public virtual DbSet<StateDetail> StateDetails { get; set; }

    public virtual DbSet<TableCity> TableCities { get; set; }

    public virtual DbSet<TableCity1> TableCity1s { get; set; }

    public virtual DbSet<TblCity> TblCities { get; set; }

    public virtual DbSet<TblState> TblStates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-1B2K66Q1;Database=crud;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CityDetail>(entity =>
        {
            entity.HasKey(e => e.CityId);

            entity.Property(e => e.CityName).HasMaxLength(50);
        });

        modelBuilder.Entity<EmployeeTbl>(entity =>
        {
            entity.HasKey(e => e.EmployeeId);

            entity.ToTable("Employee_Tbl");

            entity.Property(e => e.ContectNo).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Fname).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Lname).HasMaxLength(50);
        });

        modelBuilder.Entity<StateDetail>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.Property(e => e.StateName).HasMaxLength(50);
        });

        modelBuilder.Entity<TableCity>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__table_Ci__F2D21B76F33E1307");

            entity.ToTable("table_City");

            entity.Property(e => e.CityName).HasMaxLength(100);
        });

        modelBuilder.Entity<TableCity1>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__table_Ci__F2D21B76F028FA7C");

            entity.ToTable("table_City1");

            entity.Property(e => e.CityName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblCity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbl_City__3214EC07BBE4A14B");

            entity.ToTable("tbl_City");

            entity.Property(e => e.CityName).HasMaxLength(100);
            entity.Property(e => e.Isactive).HasColumnName("isactive");
        });

        modelBuilder.Entity<TblState>(entity =>
        {
            entity.HasKey(e => e.Stateid).HasName("PK__tbl_Stat__3214EC07D421AACB");

            entity.ToTable("tbl_State");

            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.SateName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
