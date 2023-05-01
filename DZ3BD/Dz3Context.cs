using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DZ3BD;

public partial class Dz3Context : DbContext
{
    public Dz3Context()
    {
    }

    public Dz3Context(DbContextOptions<Dz3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Dz3> Dz3s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=DZ3;Username=postgres;Password=rusolandrei");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dz3>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DZ3_id");

            entity.ToTable("DZ3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
