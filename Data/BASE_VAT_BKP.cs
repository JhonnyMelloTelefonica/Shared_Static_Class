﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("BASE_VAT_BKP")]
public partial class BASE_VAT_BKP
{
    [Column("ORIGEM DA VERBA")]
    [StringLength(255)]
    public string ORIGEM_DA_VERBA { get; set; }

    [StringLength(255)]
    public string REGIONAL { get; set; }

    [StringLength(255)]
    public string MES { get; set; }

    [StringLength(255)]
    public string UF { get; set; }

    [StringLength(255)]
    public string TERRITORIO { get; set; }

    public double? DDD { get; set; }

    [StringLength(255)]
    public string CANAL { get; set; }

    [Column("DISTRIBUICAO%")]
    [StringLength(255)]
    public string DISTRIBUICAO_ { get; set; }

    [Column("LLPP %")]
    public double? LLPP__ { get; set; }

    [Column("PAP / CONDOMINIO %")]
    public double? PAP___CONDOMINIO__ { get; set; }

    [Column("REVENDA %")]
    public double? REVENDA__ { get; set; }

    [Column("VAREJO %")]
    [StringLength(255)]
    public string VAREJO__ { get; set; }

    [Column("CAMPANHA/ PRODUTO")]
    [StringLength(255)]
    public string CAMPANHA__PRODUTO { get; set; }

    [StringLength(255)]
    public string CONTRATO { get; set; }

    [Column("COMBO ")]
    [StringLength(255)]
    public string COMBO_ { get; set; }

    [Column("TIPO DE ACAO")]
    [StringLength(255)]
    public string TIPO_DE_ACAO { get; set; }

    [Column("MECANICA OBJETIVO")]
    public string MECANICA_OBJETIVO { get; set; }

    [Column("ITEM LPU (RESUMIDO)")]
    [StringLength(255)]
    public string ITEM_LPU__RESUMIDO_ { get; set; }

    [Column("RANGE LPU")]
    [StringLength(255)]
    public string RANGE_LPU { get; set; }

    [Column("Contrato 2")]
    [StringLength(255)]
    public string Contrato_2 { get; set; }

    [Column("CAPITAL / INTERIOR - AMOSTRA / PROD# FINAL")]
    [StringLength(255)]
    public string CAPITAL___INTERIOR___AMOSTRA___PROD__FINAL { get; set; }

    [StringLength(255)]
    public string Detalhe_Range { get; set; }

    [Column("Unid# de medida")]
    [StringLength(255)]
    public string Unid__de_medida { get; set; }

    [Column("QTD CONT /_UNID MEDIDA")]
    public double? QTD_CONT___UNID_MEDIDA { get; set; }

    [Column("R$_UNITARIO", TypeName = "money")]
    public decimal? R__UNITARIO { get; set; }

    [Column("R$ TOTAL_(sem honorario)", TypeName = "money")]
    public decimal? R__TOTAL__sem_honorario_ { get; set; }

    [Column("%_HONORARIO")]
    public double? __HONORARIO { get; set; }

    [Column("R$_HONORARIO", TypeName = "money")]
    public decimal? R__HONORARIO { get; set; }

    [Column("R$ TOTAL + HONORARIO", TypeName = "money")]
    public decimal? R__TOTAL___HONORARIO { get; set; }

    [Column("AGENCIA/ FORNECEDOR")]
    [StringLength(255)]
    public string AGENCIA__FORNECEDOR { get; set; }

    [Column("NOME DO PARCEIRO")]
    [StringLength(255)]
    public string NOME_DO_PARCEIRO { get; set; }

    [Column("COD# SAP PARCEIRO")]
    public double? COD__SAP_PARCEIRO { get; set; }

    [Column("Nº PEDIDO - HONORARIO")]
    public double? Nº_PEDIDO___HONORARIO { get; set; }

    [Column("NOME DO PARCEIRO1")]
    [StringLength(255)]
    public string NOME_DO_PARCEIRO1 { get; set; }

    [Column("CÓD# SAP PARCEIRO")]
    public double? CÓD__SAP_PARCEIRO { get; set; }

    [Column("Nº  PEDIDO SERVIÇO/MATERIAL")]
    public double? Nº__PEDIDO_SERVIÇO_MATERIAL { get; set; }

    [Column("CENTRO DE CUSTO")]
    [StringLength(255)]
    public string CENTRO_DE_CUSTO { get; set; }

    [StringLength(255)]
    public string ADABAS { get; set; }

    [Column("DATA INICIO DA AÇÃO", TypeName = "datetime")]
    public DateTime? DATA_INICIO_DA_AÇÃO { get; set; }

    [Column("DATA FINAL DA AÇÃO ", TypeName = "datetime")]
    public DateTime? DATA_FINAL_DA_AÇÃO_ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HORÁRIO { get; set; }

    [Column("NOME LOJA/ PARCEIRO/ DISTRIBUIDOR")]
    [StringLength(255)]
    public string NOME_LOJA__PARCEIRO__DISTRIBUIDOR { get; set; }

    [StringLength(255)]
    public string ENDEREÇO { get; set; }

    [StringLength(255)]
    public string BAIRRO { get; set; }

    [StringLength(255)]
    public string CIDADE { get; set; }

    [Column("TIPO LOJA")]
    [StringLength(255)]
    public string TIPO_LOJA { get; set; }

    [StringLength(255)]
    public string OBSERVAÇÕES { get; set; }

    [Column("DADOS EQUIPE COMERCIAL")]
    [StringLength(255)]
    public string DADOS_EQUIPE_COMERCIAL { get; set; }

    [Column("DADOS PROFISSIONAL CONTRATO")]
    [StringLength(255)]
    public string DADOS_PROFISSIONAL_CONTRATO { get; set; }

    [StringLength(255)]
    public string F50 { get; set; }

    [StringLength(255)]
    public string F51 { get; set; }
}