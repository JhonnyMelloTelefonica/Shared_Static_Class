﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_BD_CATEGORIA")]
public partial class BOLETA_BD_CATEGORIum
{
    [Key]
    public int ID_CATEGORIA { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string CATEGORIA { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ID_PLATAFORMA { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string MOVIMENTO { get; set; }
}