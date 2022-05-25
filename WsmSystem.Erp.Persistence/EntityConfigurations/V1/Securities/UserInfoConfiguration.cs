﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WsmSystem.Erp.Domain.Entities.V1.Securities;

namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class UserInfoConfiguration : IEntityTypeConfiguration<UserInfo>
    {
        public void Configure(EntityTypeBuilder<UserInfo> builder)
        {
            builder.ToTable(@"UserInfo", @"securities");
            builder.Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.AccessLevel).HasColumnName(@"AccessLevel").HasColumnType(@"nvarchar(4)").ValueGeneratedNever().HasMaxLength(4);
            builder.Property(x => x.UserName).HasColumnName(@"UserName").HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.UserFullName).HasColumnName(@"UserFullName").HasColumnType(@"nvarchar(100)").ValueGeneratedNever().HasMaxLength(100);
            builder.Property(x => x.UserPassword).HasColumnName(@"UserPassword").HasColumnType(@"nvarchar(500)").IsRequired().ValueGeneratedNever().HasMaxLength(500);
            builder.Property(x => x.PasswordSalt).HasColumnName(@"PasswordSalt").HasColumnType(@"nvarchar(500)").ValueGeneratedNever().HasMaxLength(500);
            builder.Property(x => x.IdRole).HasColumnName(@"IdRole").HasColumnType(@"int").ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType(@"bit").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"1");
            builder.Property(x => x.UserEmail).HasColumnName(@"UserEmail").HasColumnType(@"nvarchar(100)").ValueGeneratedNever().HasMaxLength(100);
            builder.Property(x => x.IsLockedOut).HasColumnName(@"IsLockedOut").HasColumnType(@"bit").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"0");
            builder.Property(x => x.ChangePassword).HasColumnName(@"ChangePassword").HasColumnType(@"bit").ValueGeneratedOnAdd().HasDefaultValueSql(@"0");
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"nvarchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
            builder.Property(x => x.MakeBy).HasColumnName(@"MakeBy").HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.MakeDate).HasColumnName(@"MakeDate").HasColumnType(@"datetime2").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"getdate()");
            builder.Property(x => x.UpdateBy).HasColumnName(@"UpdateBy").HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType(@"datetime2").ValueGeneratedNever();
            builder.HasKey(@"IdClient", @"Id");

        }
    }
}