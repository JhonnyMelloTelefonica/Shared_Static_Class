﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_VALOR_PLANOS")]
public partial class BOLETA_VALOR_PLANO
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string Plano { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Valor { get; set; }
}