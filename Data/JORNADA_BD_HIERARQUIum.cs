﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("JORNADA_BD_HIERARQUIA")]
public partial class JORNADA_BD_HIERARQUIum
{
    [Key]
    public int ID { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string ADABAS { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string NOME_FANTASIA { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string REDE { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string UF { get; set; }

    public int? DDD { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string REGIONAL { get; set; }

    public bool? STATUS { get; set; }

    public int? LOGIN_MOD { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DT_MOD { get; set; }

    public int? RE_DIVISAO { get; set; }

    public int? RE_GA { get; set; }

    public int? RE_GP { get; set; }

    public int? RE_GV { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CANAL { get; set; }
}