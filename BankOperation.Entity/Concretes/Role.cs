using System;
using System.Collections.Generic;

namespace BankOperation.Entity.Concretes;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? InsertedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? InsertedUserId { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<RoleGroup> RoleGroups { get; } = new List<RoleGroup>();

    public virtual ICollection<User> Users { get; } = new List<User>();
}
