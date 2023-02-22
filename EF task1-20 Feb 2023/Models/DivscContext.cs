using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCONSOLE.Models;

public partial class DivscContext : DbContext
{
    public DivscContext()
    {
    }

    public DivscContext(DbContextOptions<DivscContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=divsc;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("pk_deptid");

            entity.ToTable("dept");

            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("pk_empid");

            entity.ToTable("employee");

            entity.Property(e => e.Empgender)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Employeename)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Dept).WithMany(p => p.Employees)
                .HasForeignKey(d => d.Deptid)
                .HasConstraintName("fk_deptid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
