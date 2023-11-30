using System;
using System.Collections.Generic;

namespace BankOperation.Entity.Concretes;

public partial class RoleGroup
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public int? GroupId { get; set; }

    public bool? CanEdit { get; set; }

    public bool? CanView { get; set; }

    public bool? CanInsert { get; set; }

    public bool? CanDelete { get; set; }

    public bool? CanExport { get; set; }

    public DateTime? InsertedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? InsertedUserId { get; set; }

    public bool? IsActive { get; set; }

    public virtual Group? Group { get; set; }

    public virtual Role? Role { get; set; }
}
