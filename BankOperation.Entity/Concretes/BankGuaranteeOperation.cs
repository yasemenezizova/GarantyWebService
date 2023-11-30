using System;
using System.Collections.Generic;

namespace BankOperation.Entity.Concretes;

public partial class BankGuaranteeOperation
{
    public int Id { get; set; }

    public int? GuaranteeId { get; set; }

    public decimal? UsedLimit { get; set; }

    public DateTime? InsertedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? InsertedUserId { get; set; }

    public bool? IsActive { get; set; }

    public virtual Guarantee? Guarantee { get; set; }
}
