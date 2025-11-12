using System;
using System.Collections.Generic;

namespace mvcadmin10.Models;

public partial class WorkflowRoles
{
    public int Id { get; set; }

    public bool IsAgentMode { get; set; }

    public bool IsUnitSupervisor { get; set; }

    public string? RoleNo { get; set; }

    public string? RoleName { get; set; }

    public string? UserNo { get; set; }

    public string? AgentNo { get; set; }

    public string? Remark { get; set; }
}
