﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using WsmSystem.Erp.Local.Models;

#nullable disable

namespace WsmSystem.Erp.Local.Models.Configurations
{
    public partial class EmailTemplateConfiguration : IEntityTypeConfiguration<EmailTemplate>
    {
        public void Configure(EntityTypeBuilder<EmailTemplate> entity)
        {
            entity.HasKey(e => new { e.IdClient, e.Id });

            entity.ToTable("EmailTemplate", "core");

            entity.Property(e => e.IdAuthorizationStatus).HasMaxLength(1);
            entity.Property(e => e.IsActive)
            .IsRequired()
            .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastAction).HasMaxLength(50);
            entity.Property(e => e.MakeBy).HasMaxLength(50);
            entity.Property(e => e.MakeDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Subject).HasMaxLength(500);
            entity.Property(e => e.TemplateBody).IsUnicode(false);
            entity.Property(e => e.TemplateName).HasMaxLength(60);
            entity.Property(e => e.UpdateBy).HasMaxLength(50);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EmailTemplate> entity);
    }
}
