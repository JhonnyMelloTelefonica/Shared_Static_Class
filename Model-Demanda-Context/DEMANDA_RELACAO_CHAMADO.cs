﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Newtonsoft.Json;
using Shared_Static_Class.Model_Demanda_Context;

namespace Shared_Static_Class.Data;

[Table("DEMANDA_RELACAO_CHAMADO", Schema = "Demandas")]
public partial class DEMANDA_RELACAO_CHAMADO
{
    [Key]
    public Guid ID_RELACAO { get; set; }
    public int ID_CHAMADO { get; set; }
    public int Sequence { get; set; }
    public DateTime DATA_ABERTURA { get; set; }
    public int MATRICULA_SOLICITANTE { get; set; }
    public int? MATRICULA_RESPONSAVEL { get; set; }
    public bool PRIORIDADE { get; set; }
    public bool PRIORIDADE_SEGMENTO { get; set; }  /* Coluna se aplica apenas a DEMANDAS */
    [Required]
    public Tabela_Demanda Tabela { get; set; }
    public string LastStatus { get; set; }
    public string REGIONAL { get; set; } = string.Empty;
    /** Tabelas de relação **/
    [InverseProperty("Relacao")]
    public virtual DEMANDA_CHAMADO? ChamadoRelacao { get; set; } = null;
    [InverseProperty("Relacao")]
    public virtual DEMANDA_ACESSOS? AcessoRelacao { get; set; } = null;
    [InverseProperty("Relacao")]
    public virtual DEMANDA_DESLIGAMENTOS? DesligamentoRelacao { get; set; } = null;

    [InverseProperty("Relacao_DEMANDA")]
    [JsonIgnore]
    public virtual ICollection<DEMANDA_CHAMADO_RESPOSTA> Respostas { get; set; } = [];
    [InverseProperty("Relacao_DEMANDA")]
    [JsonIgnore]
    public virtual ICollection<DEMANDA_STATUS_CHAMADO> Status { get; set; } = [];

    [InverseProperty("DemandaRelacao")]
    [JsonIgnore]
    public virtual DEMANDA_RELACAO_TREINAMENTO_FINALIZADO? Treinamento { get; set; } = null;

    [ForeignKey("MATRICULA_SOLICITANTE")]
    [JsonIgnore]
    public virtual ACESSOS_MOBILE Solicitante { get; set; }

    [ForeignKey("MATRICULA_RESPONSAVEL")]
    [JsonIgnore]
    public virtual ACESSOS_MOBILE? Responsavel { get; set; }

    [InverseProperty("DEMANDANav")]
    [JsonIgnore]
    public virtual ICollection<CHAMADO_HISTORICO_PRIORIDADE> Historico_Prioridade { get; set; } = [];
    [InverseProperty("Relacao_DEMANDA")]
    [JsonIgnore]
    public virtual ICollection<DEMANDA_OBSERVACOES_ANALISTAS> Observacoes { get; set; } = [];

    /** Tabelas de relação **/
    public enum Tabela_Demanda
    {
        [Display(Name = "Demanda")]
        ChamadoRelacao = 1,
        [Display(Name = "Acesso")]
        AcessoRelacao = 2,
        [Display(Name = "Desligamento")]
        DesligamentoRelacao = 3
    }
}
