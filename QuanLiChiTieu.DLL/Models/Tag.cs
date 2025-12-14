using System;
using System.Collections.Generic;

namespace QuanLiChiTieu.DLL.Models;

public partial class Tag
{
    public int TagId { get; set; }

    public int UserId { get; set; }

    public string TagName { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
