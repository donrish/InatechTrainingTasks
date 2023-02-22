using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KoreDbFirst.Models;

public partial class MasterContext : DbContext
{
    public MasterContext()
    {
    }

    public MasterContext(DbContextOptions<MasterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Registration> Registrations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Registration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("registration");

            entity.Property(e => e.Firstname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.Regno).HasColumnName("regno");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
