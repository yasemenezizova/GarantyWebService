using System;
using System.Collections.Generic;

namespace BankOperation.Entity.Concretes;

public partial class BankGuarantee
{
    public int Id { get; set; }

    public int? BankId { get; set; }

    public int? CompanyId { get; set; }

    public DateTime? InsertedDate { get; set; }

    public DateTime? UpdatesDate { get; set; }

    public int? InsertedUserId { get; set; }

    public bool? IsActive { get; set; }

    public virtual Bank? Bank { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ICollection<Guarantee> Guarantees { get; } = new List<Guarantee>();
}
