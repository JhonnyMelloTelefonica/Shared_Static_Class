﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("MARKETSHARE")]
public partial class MARKETSHARE
{
    public double? DDD { get; set; }

    public double? TOTAL { get; set; }

    public double? PRÉ { get; set; }

    [Column("POS VOZ")]
    public double? POS_VOZ { get; set; }

    public double? MODEM { get; set; }
}