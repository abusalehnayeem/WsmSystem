﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using WsmSystem.Erp.Local.Entities;

namespace WsmSystem.Erp.Local.Entities.Configurations
{
    public partial class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> entity)
        {
            entity.HasKey(e => new { e.IdClient, e.Id });

            entity
            .ToTable("UserRole", "core")
            .ToTable(tb => tb.IsTemporal(ttb =>
                {
                    ttb.UseHistoryTable("UserRoleHistory", "core");
                    ttb
                        .HasPeriodStart("StartTime")
                        .HasColumnName("StartTime");
                    ttb
                        .HasPeriodEnd("EndTime")
                        .HasColumnName("EndTime");
                }));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
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
            entity.Property(e => e.RoleDescription).HasMaxLength(500);
            entity.Property(e => e.RoleName)
            .IsRequired()
            .HasMaxLength(50);
            entity.Property(e => e.UpdateBy).HasMaxLength(50);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<UserRole> entity);
    }
}
