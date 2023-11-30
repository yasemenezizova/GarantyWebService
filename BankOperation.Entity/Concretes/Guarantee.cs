using System;
using System.Collections.Generic;

namespace BankOperation.Entity.Concretes;

public partial class Guarantee
{
    public int Id { get; set; }

    public decimal? Limit { get; set; }

    public decimal? RemainingLimit { get; set; }

    public string? GuaranteeNo { get; set; }

    public DateTime? DueDate { get; set; }

    public int? FileId { get; set; }

    public int? BankGuaranteesId { get; set; }

    public DateTime? InsertedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? InsertedUserId { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<BankGuaranteeOperation> BankGuaranteeOperations { get; } = new List<BankGuaranteeOperation>();

    public virtual BankGuarantee? BankGuarantees { get; set; }

    public virtual ICollection<CustomsGuarantee> CustomsGuarantees { get; } = new List<CustomsGuarantee>();
}
