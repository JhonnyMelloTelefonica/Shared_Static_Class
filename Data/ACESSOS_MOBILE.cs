﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("ACESSOS_MOBILE", Schema = "dbo")]
public partial class ACESSOS_MOBILE
{
    [Key]
    public int ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string EMAIL { get; set; }
    public int? MATRICULA { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string SENHA { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string REGIONAL { get; set; }

    public int CARGO { get; set; }

    public int CANAL { get; set; }

    [Unicode(false)]
    public string PDV { get; set; }

    [Unicode(false)]
    public string CPF { get; set; }

    [Unicode(false)]
    public string NOME { get; set; }

    [Unicode(false)]
    public string UF { get; set; }

    public bool? STATUS { get; set; }

    public bool? FIXA { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string TP_AFASTAMENTO { get; set; }

    [Unicode(false)]
    public string OBS { get; set; }

    public byte[] UserAvatar { get; set; }

    public int? LOGIN_MOD { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DT_MOD { get; set; }

    public bool? ELEGIVEL { get; set; }

    public int? DDD { get; set; }

    public int? TP_STATUS { get; set; }

    [InverseProperty("Responsavel")]
    [JsonIgnore]
    public virtual ICollection<DEMANDA_CHAMADO>? DemandasResponsavel { get; set; } = new List<DEMANDA_CHAMADO>();

    [InverseProperty("Solicitante")]
    [JsonIgnore]
    public virtual ICollection<DEMANDA_CHAMADO>? DemandasSolicitadas { get; set; } = new List<DEMANDA_CHAMADO>();

    [InverseProperty("Responsavel")]
    [JsonIgnore]
    public virtual ICollection<DEMANDA_CHAMADO_RESPOSTA>? RespostasDemandas { get; set; } = new List<DEMANDA_CHAMADO_RESPOSTA>();
}