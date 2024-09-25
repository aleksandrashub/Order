using System;
using System.Collections.Generic;

namespace Order.Models;

public partial class Role
{
    public int IdRole { get; set; }

    public string? NameRole { get; set; }

    public virtual ICollection<Visit> Visits { get; set; } = new List<Visit>();
}
