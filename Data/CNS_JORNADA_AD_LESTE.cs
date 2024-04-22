﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
public partial class CNS_JORNADA_AD_LESTE
{
    public int? ID_PROVA { get; set; }

    [Unicode(false)]
    public string NOME { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string MATRICULA { get; set; }

    [Unicode(false)]
    public string PDV { get; set; }

    [Unicode(false)]
    public string UF { get; set; }

    public int? DDD { get; set; }

    public bool? ELEGIVEL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string TP_STATUS { get; set; }

    [StringLength(255)]
    public string CARGO { get; set; }

    [StringLength(255)]
    public string CANAL { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DT_CRIACAO { get; set; }

    [Unicode(false)]
    public string TP_FORMS { get; set; }

    public int? TT_CRIADAS { get; set; }

    public int? TT_APLICADA { get; set; }
}