using System;
using System.Collections.Generic;

namespace KoreDbFirst.Models;

public partial class Employee
{
    public int Employeeid { get; set; }

    public string? Employeename { get; set; }

    public string? Empgender { get; set; }

    public int? Deptid { get; set; }

    public string? Designation { get; set; }

    public string? Gender { get; set; }

    public virtual Dept? Dept { get; set; }
}
