﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("PERFIL_VIVO_TASK")]
public partial class PERFIL_VIVO_TASK
{
    [Key]
    public int ID { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string CARGO { get; set; }

    public int? VIVO_MAIS { get; set; }

    public int? RTCZ { get; set; }

    public int? FIXA { get; set; }
}