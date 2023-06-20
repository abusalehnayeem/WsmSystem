﻿using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class SmtpClient
{
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

    /// <summary>
    /// ((0))
    /// </summary>
    public bool? IsActive { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
