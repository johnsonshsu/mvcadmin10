using System;
using System.Collections.Generic;

namespace mvcadmin10.Models;

public partial class LogCodes
{
    public int Id { get; set; }

    public string? CodeNo { get; set; }

    public string? CodeName { get; set; }

    public string? LogLevel { get; set; }

    public string? LogInterval { get; set; }

    public string? Remark { get; set; }
}
