using System;
using System.Collections.Generic;

namespace BankOperation.Entity.Concretes;

public partial class Custom
{
    public int Id { get; set; }

    public decimal CodeN { get; set; }

    public string FullName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public bool? Border { get; set; }

    public DateTime? InsertDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool? IsActive { get; set; }

    public string Voen { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string? Adress { get; set; }

    public virtual ICollection<CustomsGuarantee> CustomsGuarantees { get; } = new List<CustomsGuarantee>();

    public virtual ICollection<User> Users { get; } = new List<User>();
}
