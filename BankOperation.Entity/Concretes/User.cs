using System;
using System.Collections.Generic;

namespace BankOperation.Entity.Concretes;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public int Type { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? RoleId { get; set; }

    public string Password { get; set; } = null!;

    public DateTime? InsertedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? InsertedUserId { get; set; }

    public bool? IsActive { get; set; }

    public string? UserGuid { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public int? BankId { get; set; }

    public int? CompanyId { get; set; }

    public int? CustomId { get; set; }

    public virtual Bank? Bank { get; set; }

    public virtual Company? Company { get; set; }

    public virtual Custom? Custom { get; set; }

    public virtual Role? Role { get; set; }
}
