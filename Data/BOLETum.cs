﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("BOLETA")]
public partial class BOLETum
{
    public int ID { get; set; }

    [Unicode(false)]
    public string TipoBoleta { get; set; }

    [Unicode(false)]
    public string Instancia { get; set; }

    [Unicode(false)]
    public string PlanoVivoFibra { get; set; }

    [Unicode(false)]
    public string Pontuacao { get; set; }

    [Unicode(false)]
    public string TelContato1 { get; set; }

    [Unicode(false)]
    public string TelContato2 { get; set; }

    [Unicode(false)]
    public string TelContato3 { get; set; }

    [Unicode(false)]
    public string EmailCliente { get; set; }

    [Unicode(false)]
    public string CodVendaFibra { get; set; }

    [Unicode(false)]
    public string ProtocoloGed { get; set; }

    [Unicode(false)]
    public string ProtocoloVendaFibra { get; set; }

    [Unicode(false)]
    public string TipoVenda { get; set; }

    [Unicode(false)]
    public string PlanoSmart { get; set; }

    [Unicode(false)]
    public string PlanoControle { get; set; }

    [Unicode(false)]
    public string PlanoDados { get; set; }

    public int? IdVendaBoleta { get; set; }

    [StringLength(350)]
    [Unicode(false)]
    public string PlanoBandaLarga { get; set; }

    [StringLength(350)]
    [Unicode(false)]
    public string PlanoFixo { get; set; }

    [StringLength(350)]
    [Unicode(false)]
    public string PlanoTv { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Linha { get; set; }

    [StringLength(350)]
    [Unicode(false)]
    public string TipoSVA { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string NomeCliente { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CpfCliente { get; set; }
}