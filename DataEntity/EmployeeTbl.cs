﻿using System;
using System.Collections.Generic;

namespace DataEntity;

public partial class EmployeeTbl
{
    public int EmployeeId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public string? ContectNo { get; set; }

    public DateTime? Dob { get; set; }

    public int? CityId { get; set; }

    public int? IsActive { get; set; }
}
