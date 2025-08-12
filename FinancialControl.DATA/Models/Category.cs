#nullable disable
using System;
using System.Collections.Generic;

namespace FinancialControl.DATA.Models;

public partial class Category
{
    public int Id { get; set; }

    public string CategoryName { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}