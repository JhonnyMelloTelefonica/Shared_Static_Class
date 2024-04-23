﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
public partial class CNS_BASE_PARCEIROS_PAP
{
    [StringLength(255)]
    public string FILA { get; set; }

    [Required]
    [StringLength(7)]
    [Unicode(false)]
    public string TIPO_CHAMADO { get; set; }

    public int? ID { get; set; }

    public int MATRICULA_RESPONSAVEL { get; set; }

    [Required]
    [StringLength(35)]
    [Unicode(false)]
    public string RESPONSAVEL { get; set; }

    public int? MATRICULA_SOLICITANTE { get; set; }

    [StringLength(255)]
    public string SOLICITANTE { get; set; }

    [StringLength(255)]
    public string STATUS { get; set; }

    [StringLength(255)]
    public string Expr1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_ABERTURA { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_RESPOSTA { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_ENCERRAMENTO { get; set; }

    [StringLength(255)]
    public string Adabás { get; set; }

    public int QTDE { get; set; }
}