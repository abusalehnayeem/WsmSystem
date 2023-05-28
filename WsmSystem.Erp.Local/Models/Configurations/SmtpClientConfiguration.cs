﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using WsmSystem.Erp.Local.Models;

#nullable disable

namespace WsmSystem.Erp.Local.Models.Configurations
{
    public partial class SmtpClientConfiguration : IEntityTypeConfiguration<SmtpClient>
    {
        public void Configure(EntityTypeBuilder<SmtpClient> entity)
        {
            entity.HasKey(e => new { e.IdClient, e.Id });

            entity.ToTable("SmtpClient", "core");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsActive)
            .IsRequired()
            .HasDefaultValueSql("((1))")
            .HasComment("((0))");
            entity.Property(e => e.LastAction).HasMaxLength(3);
            entity.Property(e => e.MakeBy).HasMaxLength(50);
            entity.Property(e => e.MakeDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Password).HasMaxLength(256);
            entity.Property(e => e.SenderMail).HasMaxLength(200);
            entity.Property(e => e.Server).HasMaxLength(500);
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SmtpClient> entity);
    }
}
