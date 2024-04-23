﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("CADASTRO_GERAL_COLABORADORES_PENDENTES")]
public partial class CADASTRO_GERAL_COLABORADORES_PENDENTE
{
    public double? ANO { get; set; }

    [StringLength(14)]
    public string MÊS { get; set; }

    [StringLength(50)]
    public string STATUS { get; set; }

    [StringLength(255)]
    public string MATRÍCULA { get; set; }

    [StringLength(50)]
    public string NOME { get; set; }

    [StringLength(50)]
    public string EMPRESA { get; set; }

    [Column("CÓDIGO EMPRESA")]
    public double? CÓDIGO_EMPRESA { get; set; }

    [Column("NOME EMPRESA")]
    [StringLength(50)]
    public string NOME_EMPRESA { get; set; }

    [StringLength(50)]
    public string REGIONAL { get; set; }

    [StringLength(50)]
    public string FILIAL { get; set; }

    [StringLength(50)]
    public string SUBAREA { get; set; }

    [Column("CÓDIGO UNIDADE")]
    public double? CÓDIGO_UNIDADE { get; set; }

    [Column("ESTADO COMERCIAL")]
    [StringLength(50)]
    public string ESTADO_COMERCIAL { get; set; }

    [Column("CIDADE COMERCIAL")]
    [StringLength(50)]
    public string CIDADE_COMERCIAL { get; set; }

    [Column("BAIRRO COMERCIAL")]
    [StringLength(50)]
    public string BAIRRO_COMERCIAL { get; set; }

    [Column("ENDEREÇO COMERCIAL")]
    [StringLength(100)]
    public string ENDEREÇO_COMERCIAL { get; set; }

    [Column("NÚMERO COMERCIAL")]
    [StringLength(100)]
    public string NÚMERO_COMERCIAL { get; set; }

    [Column("COMPLEMENTO COMERCIAL")]
    [StringLength(100)]
    public string COMPLEMENTO_COMERCIAL { get; set; }

    [Column("CEP COMERCIAL")]
    [StringLength(50)]
    public string CEP_COMERCIAL { get; set; }

    [StringLength(50)]
    public string VP { get; set; }

    [Column("DIRETORIA 1")]
    [StringLength(50)]
    public string DIRETORIA_1 { get; set; }

    [Column("DIRETORIA 2")]
    [StringLength(50)]
    public string DIRETORIA_2 { get; set; }

    [Column("DIRETORIA 3")]
    [StringLength(50)]
    public string DIRETORIA_3 { get; set; }

    [Column("GERÊNCIA SR")]
    [StringLength(50)]
    public string GERÊNCIA_SR { get; set; }

    [StringLength(50)]
    public string GERÊNCIA { get; set; }

    [StringLength(50)]
    public string ÁREA { get; set; }

    [StringLength(50)]
    public string SIGLA { get; set; }

    [Column("MATRÍCULA GESTOR")]
    [StringLength(50)]
    public string MATRÍCULA_GESTOR { get; set; }

    [StringLength(50)]
    public string GESTOR { get; set; }

    [Column("E-MAIL GESTOR")]
    [StringLength(50)]
    public string E_MAIL_GESTOR { get; set; }

    [Column("CENTRO DE CUSTO")]
    [StringLength(50)]
    public string CENTRO_DE_CUSTO { get; set; }

    [Column("OBJETO DE CUSTO")]
    [StringLength(50)]
    public string OBJETO_DE_CUSTO { get; set; }

    [StringLength(50)]
    public string CARGO { get; set; }

    [StringLength(50)]
    public string CATEGORIA { get; set; }

    [StringLength(50)]
    public string SUBGRUPO { get; set; }

    [StringLength(50)]
    public string POSIÇÃO { get; set; }

    [Column("POSIÇÃO SAP")]
    public double? POSIÇÃO_SAP { get; set; }

    [StringLength(30)]
    public string LOJA { get; set; }

    [Column("CALL CENTER")]
    [StringLength(255)]
    public string CALL_CENTER { get; set; }

    [Column("DATA ADMISSÃO", TypeName = "datetime")]
    public DateTime? DATA_ADMISSÃO { get; set; }

    [Column("DATA DESLIGAMENTO", TypeName = "datetime")]
    public DateTime? DATA_DESLIGAMENTO { get; set; }

    [StringLength(255)]
    public string AFASTAMENTO { get; set; }

    [StringLength(255)]
    public string ESTABILIDADE { get; set; }

    [Column("QTD FILHOS")]
    public double? QTD_FILHOS { get; set; }

    [Column("FÉRIAS NO MÊS")]
    [StringLength(255)]
    public string FÉRIAS_NO_MÊS { get; set; }

    [Column("INÍCIO FÉRIAS", TypeName = "datetime")]
    public DateTime? INÍCIO_FÉRIAS { get; set; }

    [Column("FIM FÉRIAS", TypeName = "datetime")]
    public DateTime? FIM_FÉRIAS { get; set; }

    [Column("E-MAIL")]
    [StringLength(40)]
    public string E_MAIL { get; set; }

    [StringLength(20)]
    public string CELULAR { get; set; }

    [StringLength(255)]
    public string CPF { get; set; }

    [StringLength(20)]
    public string GÊNERO { get; set; }

    [Column("DATA DE NASCIMENTO", TypeName = "datetime")]
    public DateTime? DATA_DE_NASCIMENTO { get; set; }

    [StringLength(20)]
    public string IDADE { get; set; }

    [Column("FAIXA DE IDADE")]
    [StringLength(20)]
    public string FAIXA_DE_IDADE { get; set; }

    [Key]
    public int ID_Pendente { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataSolicitacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataUltimaAlteracao { get; set; }

    [StringLength(100)]
    public string Status_Pendente { get; set; }

    public int? ID_Orig { get; set; }

    [StringLength(20)]
    public string Motivo { get; set; }

    [StringLength(100)]
    public string ObservacaoDesligamento { get; set; }

    public int? idSolicitanteDesligamento { get; set; }
}