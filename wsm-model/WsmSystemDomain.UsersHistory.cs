﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 7/21/2023 10:48:20 AM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace WsmSystemModel
{
    public partial class UsersHistory {

        public UsersHistory()
        {
            OnCreated();
        }

        public int IdClient { get; set; }

        public int Id { get; set; }

        public string UserName { get; set; }

        public string UserFullName { get; set; }

        public string Email { get; set; }

        public string EmployeeId { get; set; }

        public string Password { get; set; }

        public string PasswordSalt { get; set; }

        public string AccessLevel { get; set; }

        public int IdRole { get; set; }

        public int IdUserLanguage { get; set; }

        public string IdAuthorizationStatus { get; set; }

        public bool IsActive { get; set; }

        public bool IsLockedOut { get; set; }

        public bool IsChangePassword { get; set; }

        public string LastAction { get; set; }

        public string MakeBy { get; set; }

        public DateTime MakeDate { get; set; }

        public string UpdateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}