﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_BD_PLANO")]
public partial class BOLETA_BD_PLANO
{
    [Key]
    public int ID_PLANO { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TP_Cliente { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string PLANO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Origem { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ID_PLATAFORMA { get; set; }
}