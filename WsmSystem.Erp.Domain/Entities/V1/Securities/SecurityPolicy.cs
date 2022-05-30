﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 5/22/2022 12:09:13 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

namespace WsmSystem.Erp.Domain.Entities.V1.Securities
{
    public class SecurityPolicy : BaseEntity
    {
        public SecurityPolicy(int id, int idClient, int maximumWrongLoginTry, int minimumPasswordLength, int? passwordAttemptWindow, int? userOnlineTimeWindow, bool isAlphaNumericPasswordRequired, bool? isPasswordSaltRequired, bool isPasswordStrengthRequired, bool isUniqueEmailRequired, bool isActive)
        {
            Id = id;
            IdClient = idClient;
            MaximumWrongLoginTry = maximumWrongLoginTry;
            MinimumPasswordLength = minimumPasswordLength;
            PasswordAttemptWindow = passwordAttemptWindow;
            UserOnlineTimeWindow = userOnlineTimeWindow;
            IsAlphaNumericPasswordRequired = isAlphaNumericPasswordRequired;
            IsPasswordSaltRequired = isPasswordSaltRequired;
            IsPasswordStrengthRequired = isPasswordStrengthRequired;
            IsUniqueEmailRequired = isUniqueEmailRequired;
            IsActive = isActive;
        }

        public virtual int Id { get; set; }

        public virtual int IdClient { get; set; }

        public virtual int MaximumWrongLoginTry { get; set; }

        public virtual int MinimumPasswordLength { get; set; }

        public virtual int? PasswordAttemptWindow { get; set; }

        public virtual int? UserOnlineTimeWindow { get; set; }

        public virtual bool IsAlphaNumericPasswordRequired { get; set; }

        public virtual bool? IsPasswordSaltRequired { get; set; }

        public virtual bool IsPasswordStrengthRequired { get; set; }

        public virtual bool IsUniqueEmailRequired { get; set; }
    }
}
