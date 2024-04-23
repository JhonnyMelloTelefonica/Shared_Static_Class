﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("HC_NORDESTE")]
public partial class HC_NORDESTE
{
    public double? MATRÍCULA { get; set; }

    [StringLength(255)]
    public string NOME { get; set; }

    [StringLength(255)]
    public string CARGO { get; set; }

    [StringLength(255)]
    public string CATEGORIA { get; set; }

    [StringLength(255)]
    public string SIGLA { get; set; }

    [Column("GERÊNCIA SR")]
    [StringLength(255)]
    public string GERÊNCIA_SR { get; set; }

    [StringLength(255)]
    public string GERÊNCIA { get; set; }

    [StringLength(255)]
    public string COORDENAÇÃO { get; set; }

    [StringLength(255)]
    public string ÁREA { get; set; }

    [Column("MATRÍCULA GESTOR(A)")]
    public double? MATRÍCULA_GESTOR_A_ { get; set; }

    [Column("NOME GESTOR(A)")]
    [StringLength(255)]
    public string NOME_GESTOR_A_ { get; set; }

    [Column("E-MAIL GESTOR(A)")]
    [StringLength(255)]
    public string E_MAIL_GESTOR_A_ { get; set; }

    [StringLength(255)]
    public string ESTADO { get; set; }

    [StringLength(255)]
    public string CIDADE { get; set; }

    [Column("E-MAIL")]
    [StringLength(255)]
    public string E_MAIL { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string ANOMES { get; set; }
}