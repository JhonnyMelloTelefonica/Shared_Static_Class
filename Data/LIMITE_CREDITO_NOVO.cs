﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("LIMITE_CREDITO_NOVO")]
public partial class LIMITE_CREDITO_NOVO
{
    [StringLength(150)]
    [Unicode(false)]
    public string CNPJ { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string REDE { get; set; }

    public double? LIMITE_CREDITO { get; set; }

    public double? DIVIDA_RECEBER { get; set; }

    public double? LIMITE_PLUS { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string CNPJ_RAIZ { get; set; }
}