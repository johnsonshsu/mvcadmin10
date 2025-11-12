using System;
using System.Collections.Generic;

namespace mvcadmin10.Models;

public class WorkflowUnits
{
    public int Id { get; set; }

    public string? BaseNo { get; set; }

    public string? UnitNo { get; set; }

    public string? UnitName { get; set; }

    public string? SupervisorNo { get; set; }

    public string? Remark { get; set; }
}
