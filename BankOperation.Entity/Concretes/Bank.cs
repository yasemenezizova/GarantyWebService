using System;
using System.Collections.Generic;

namespace BankOperation.Entity.Concretes;

public partial class Bank
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string Swift { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string? Address { get; set; }

    public DateTime? InsertDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool? IsActive { get; set; }

    public string CodeN { get; set; } = null!;

    public string Voen { get; set; } = null!;

    public int? InsertUserId { get; set; }

    public virtual ICollection<BankGuarantee> BankGuarantees { get; } = new List<BankGuarantee>();

    public virtual ICollection<User> Users { get; } = new List<User>();
}
