using System;
using System.Collections.Generic;

namespace DataEntity;

public partial class TblState
{
    public int Stateid { get; set; }

    public string? SateName { get; set; }

    public bool? Isactive { get; set; }
}
