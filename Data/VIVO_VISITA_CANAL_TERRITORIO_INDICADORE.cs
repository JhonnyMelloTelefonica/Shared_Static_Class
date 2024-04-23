﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("VIVO_VISITA_CANAL_TERRITORIO_INDICADORES")]
public partial class VIVO_VISITA_CANAL_TERRITORIO_INDICADORE
{
    [Key]
    public int Id { get; set; }

    public int IdAbertura { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ResultadosIndicadoresAvaliarPerformanceCorrenteSimNao { get; set; }

    [Unicode(false)]
    public string ResultadosIndicadoresAvaliarPerformanceCorrenteObs { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ResultadosIndicadoresIndicadoresTempoSimNao { get; set; }

    [Unicode(false)]
    public string ResultadosIndicadoresIndicadoresTempoObs { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ResultadosIndicadoresAcompanharAlgunsAtendimentosSimNao { get; set; }

    [Unicode(false)]
    public string ResultadosIndicadoresAcompanharAlgunsAtendimentosObs { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ResultadosIndicadoresRentabilidadeSimNao { get; set; }

    [Unicode(false)]
    public string ResultadosIndicadoresRentabilidadeObs { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCadastro { get; set; }

    [ForeignKey("IdAbertura")]
    [InverseProperty("VIVO_VISITA_CANAL_TERRITORIO_INDICADOREs")]
    public virtual VIVO_VISITA_CANAL_TERRITORIO_ABERTURA IdAberturaNavigation { get; set; }
}