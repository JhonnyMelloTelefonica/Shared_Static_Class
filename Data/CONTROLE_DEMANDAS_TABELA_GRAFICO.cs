﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("CONTROLE_DEMANDAS_TABELA_GRAFICO")]
public partial class CONTROLE_DEMANDAS_TABELA_GRAFICO
{
    [StringLength(50)]
    [Unicode(false)]
    public string TIPO { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string MESANO { get; set; }

    public int? QTD { get; set; }

    public int? IDRESPONSAVEL { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string STATUS { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string TAB_RAIZ { get; set; }
}