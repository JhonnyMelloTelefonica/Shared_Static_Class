﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("TABELAO")]
public partial class TABELAO
{
    [StringLength(100)]
    public string NomeCliente { get; set; }

    [StringLength(100)]
    public string CPFCliente { get; set; }

    [StringLength(100)]
    public string TipoMailing { get; set; }

    [StringLength(100)]
    public string TipoServicoFixa { get; set; }

    [StringLength(100)]
    public string TipoServicoMovel { get; set; }

    [StringLength(100)]
    public string TipoServicoTerminais { get; set; }

    [StringLength(400)]
    public string NomeMailing { get; set; }

    [StringLength(100)]
    public string NomePlanoFixa { get; set; }

    [StringLength(100)]
    public string NomePlanoMovel { get; set; }

    [StringLength(100)]
    public string NomePlanoTerminais { get; set; }

    [StringLength(400)]
    public string Ordem { get; set; }

    [StringLength(100)]
    public string ValorFixa { get; set; }

    [StringLength(100)]
    public string ValorFixaDelta { get; set; }

    [StringLength(100)]
    public string ValorMovel { get; set; }

    [StringLength(100)]
    public string ValorMovelDelta { get; set; }

    [StringLength(100)]
    public string ValorTerminais { get; set; }

    [StringLength(100)]
    public string ValorTerminaisDelta { get; set; }

    [StringLength(100)]
    public string GEDFixa { get; set; }

    [StringLength(100)]
    public string LinhaMovel { get; set; }

    [StringLength(100)]
    public string LinhaTerminais { get; set; }

    [StringLength(100)]
    public string GEDMovel { get; set; }

    [StringLength(100)]
    public string GEDTerminais { get; set; }

    [StringLength(100)]
    public string InstanciaFixa { get; set; }

    [StringLength(100)]
    public string DataInstalacao { get; set; }

    [StringLength(100)]
    public string DataEntrega { get; set; }

    [StringLength(100)]
    public string DataMailing { get; set; }

    [StringLength(100)]
    public string DDDCliente { get; set; }

    [StringLength(400)]
    public string MotivoNaoVenda { get; set; }

    [StringLength(100)]
    public string DataEntregaTerminais { get; set; }

    [StringLength(20)]
    public string idAcesso { get; set; }

    [Key]
    public int Id { get; set; }

    [StringLength(400)]
    public string Observacao { get; set; }

    [StringLength(400)]
    public string ServicoMailing { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataPalitagem { get; set; }

    [StringLength(10)]
    public string UfCliente { get; set; }

    [StringLength(50)]
    public string CidadeCliente { get; set; }

    [StringLength(15)]
    public string CEPCliente { get; set; }
}