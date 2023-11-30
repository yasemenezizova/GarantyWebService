using System;
using System.Collections.Generic;

namespace BankOperation.Entity.Concretes;

public partial class Company
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public DateTime? InsertDate { get; set; }

    public int? InsertUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool? IsActive { get; set; }

    public string Voen { get; set; } = null!;

    public virtual ICollection<BankGuarantee> BankGuarantees { get; } = new List<BankGuarantee>();

    public virtual ICollection<User> Users { get; } = new List<User>();
}
