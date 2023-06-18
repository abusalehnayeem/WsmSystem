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
    public partial class Notice {

        public Notice()
        {
            this.IdAuthorizationStatus = @"N";
            OnCreated();
        }

        public int IdClient { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public string NoticeBody { get; set; }

        public string AttachedFileUrl { get; set; }

        public bool IsPublished { get; set; }

        public DateTime? PublishedDate { get; set; }

        public string IdAuthorizationStatus { get; set; }

        public bool IsActive { get; set; }

        public string LastAction { get; set; }

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
          Notice toCompare = obj as Notice;
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
