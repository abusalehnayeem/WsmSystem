﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 6/18/2023 11:22:23 PM
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
    public partial class SmtpClientHistory {

        public SmtpClientHistory()
        {
            OnCreated();
        }

        public int IdClient { get; set; }

        public int Id { get; set; }

        public string Server { get; set; }

        public int Port { get; set; }

        public bool UseDefaultCredentials { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool EnableSsl { get; set; }

        public int Timeout { get; set; }

        public string SenderMail { get; set; }

        public string LastAction { get; set; }

        public string IdAuthorizationStatus { get; set; }

        public bool IsActive { get; set; }

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
