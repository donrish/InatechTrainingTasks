using System;
using System.Collections.Generic;

namespace EFCONSOLE.Models;

public partial class Dept
{
    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
