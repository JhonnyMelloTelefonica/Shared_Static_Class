﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("JORNADA_BD_CARGOS_CANAL")]
public partial class JORNADA_BD_CARGOS_CANAL
{
    public double? ID { get; set; }

    [StringLength(255)]
    public string CARGO { get; set; }

    public double? ID_CANAL { get; set; }

    [StringLength(255)]
    public string CANAL { get; set; }
}