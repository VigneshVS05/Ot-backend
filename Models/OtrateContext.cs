using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OTRate.Models;

public partial class OtrateContext : DbContext
{
    public OtrateContext()
    {
    }

    public OtrateContext(DbContextOptions<OtrateContext> options)
        : base(options)
    {
    }


    public virtual DbSet<OtRateDef> OtRateDefs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ASTLPTWFH148\\SQLEXPRESS;Initial Catalog=OTRate;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
        modelBuilder.Entity<OtRateDef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OT_RateD__3213E83FBAFCD648");

            entity.ToTable("OT_RateDef");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseComponent)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Base_Component");
            entity.Property(e => e.ConsiderForOt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Consider_for_OT");
            entity.Property(e => e.EndDate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("End_Date");
            entity.Property(e => e.HrsComponent)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Hrs_Component");
            entity.Property(e => e.MonthlyRate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Monthly_Rate");
            entity.Property(e => e.OtRate)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("OT_Rate");
            entity.Property(e => e.OtSlabName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OT_SlabName");
            entity.Property(e => e.OtSlabType)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("OT_SlabType");
            entity.Property(e => e.OtValueComponent)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OT_Value_Component");
            entity.Property(e => e.PayGroup)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Pay_Group");
            entity.Property(e => e.StartDate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Start_Date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
