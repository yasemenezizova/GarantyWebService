using System;
using System.Collections.Generic;

namespace BankOperation.Entity.Concretes;

public partial class CustomsGuarantee
{
    public int Id { get; set; }

    public int? CustomsId { get; set; }

    public int? GuaranteeId { get; set; }

    public DateTime? InsertedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? InsertedUserId { get; set; }

    public bool? IsActive { get; set; }

    public virtual Custom? Customs { get; set; }

    public virtual Guarantee? Guarantee { get; set; }
}
