﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating Repositories and a Unit of Work for EF Core model.
// Code is generated on: 7/21/2023 10:48:21 AM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace WsmSystemModel
{
    public partial interface IScreenHistoryRepository : IRepository<ScreenHistory>
    {
        ICollection<ScreenHistory> GetAll();
        ScreenHistory GetByKey();
    }
}