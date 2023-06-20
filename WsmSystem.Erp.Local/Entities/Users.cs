using System;
using System.Collections.Generic;

namespace WsmSystem.Erp.Local.Entities;

public partial class Users
{
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

    public bool? IsActive { get; set; }

    public bool IsLockedOut { get; set; }

    public bool IsChangePassword { get; set; }

    public string LastAction { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual BaseLanguage Id1 { get; set; }

    public virtual UserRole IdNavigation { get; set; }

    public virtual ICollection<UserWiseGroupMapping> UserWiseGroupMapping { get; set; } = new List<UserWiseGroupMapping>();
}
