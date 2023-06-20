﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using WsmSystem.Erp.Local.Entities;

namespace WsmSystem.Erp.Local.Entities.Configurations
{
    public partial class ScreenConfiguration : IEntityTypeConfiguration<Screen>
    {
        public void Configure(EntityTypeBuilder<Screen> entity)
        {
            entity.HasKey(e => new { e.IdClient, e.Id });

            entity
            .ToTable("Screen", "core")
            .ToTable(tb => tb.IsTemporal(ttb =>
                {
                    ttb.UseHistoryTable("ScreenHistory", "core");
                    ttb
                        .HasPeriodStart("StartTime")
                        .HasColumnName("StartTime");
                    ttb
                        .HasPeriodEnd("EndTime")
                        .HasColumnName("EndTime");
                }));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.IconName).HasMaxLength(50);
            entity.Property(e => e.IdAuthorizationStatus)
            .IsRequired()
            .HasMaxLength(1)
            .HasDefaultValueSql("('N')");
            entity.Property(e => e.LastAction)
            .IsRequired()
            .HasMaxLength(50);
            entity.Property(e => e.MakeBy)
            .IsRequired()
            .HasMaxLength(50);
            entity.Property(e => e.ScreenName)
            .IsRequired()
            .HasMaxLength(100);
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.Uri)
            .IsRequired()
            .HasMaxLength(512);

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.Screen)
            .HasForeignKey(d => new { d.IdClient, d.IdSection })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Screen_Section");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Screen> entity);
    }
}
