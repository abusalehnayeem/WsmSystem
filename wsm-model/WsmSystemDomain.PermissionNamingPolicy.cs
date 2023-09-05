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
    public partial class PermissionNamingPolicy {

        public PermissionNamingPolicy()
        {
            this.LastAction = @"ADD";
            OnCreated();
        }

        public int IdClient { get; set; }

        public int Id { get; set; }

        public string LevelName { get; set; }

        public int LevelLength { get; set; }

        public int LevelStartPoint { get; set; }

        public int LevelEndPoint { get; set; }

        public int LevelIncrementBy { get; set; }

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

        public override bool Equals(object obj)
        {
          PermissionNamingPolicy toCompare = obj as PermissionNamingPolicy;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.IdClient, toCompare.IdClient))
            return false;
          if (!Object.Equals(this.Id, toCompare.Id))
            return false;

          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + IdClient.GetHashCode();
          hashCode = (hashCode * 7) + Id.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
