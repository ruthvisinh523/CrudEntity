using System;
using System.Collections.Generic;

namespace DataEntity;

public partial class TblCity
{
    public int Id { get; set; }

    public int? SateId { get; set; }

    public string? CityName { get; set; }

    public bool? Isactive { get; set; }
}
