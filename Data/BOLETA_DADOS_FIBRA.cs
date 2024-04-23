﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_DADOS_FIBRA")]
public partial class BOLETA_DADOS_FIBRA
{
    [Key]
    public int Id { get; set; }

    public int? Id_Dados { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string Instancia { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string PontuacaoVivoFibra { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string PlanoBandaLarga { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string PlanoFixa { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string PlanoTV { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TelefoneContato1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TelefoneContato2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TelefoneContato3 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string COD { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string ProtocoloDigitalizacao { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string ProtocoloAtivacao { get; set; }

    public double? Valor { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string Matricula_CN { get; set; }
}