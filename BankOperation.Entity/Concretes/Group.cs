using System;
using System.Collections.Generic;

namespace BankOperation.Entity.Concretes;

public partial class Group
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<RoleGroup> RoleGroups { get; } = new List<RoleGroup>();
}
