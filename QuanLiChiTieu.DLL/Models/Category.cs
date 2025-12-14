using System;
using System.Collections.Generic;

namespace QuanLiChiTieu.DLL.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public int UserId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string CategoryType { get; set; } = null!;

    public string? Description { get; set; }

    public string? Color { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<Budget> Budgets { get; set; } = new List<Budget>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual User User { get; set; } = null!;
}
