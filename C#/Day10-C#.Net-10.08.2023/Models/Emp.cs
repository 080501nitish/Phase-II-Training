using System;
using System.Collections.Generic;

namespace EFDBF.Models;

public partial class Emp
{
    public int Empno { get; set; }

    public string? Ename { get; set; }

    public string? Addr { get; set; }

    public int? Deptno { get; set; }

    public virtual Dept? DeptnoNavigation { get; set; }
}
