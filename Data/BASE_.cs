﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("BASE$")]
public partial class BASE_
{
    [Column("CODIGO CARGO")]
    [StringLength(255)]
    public string CODIGO_CARGO { get; set; }

    [Column("DESCRICAO CARGO")]
    [StringLength(255)]
    public string DESCRICAO_CARGO { get; set; }

    [Column("DATA ENTRADA", TypeName = "datetime")]
    public DateTime? DATA_ENTRADA { get; set; }

    [Column("DATA SAIDA")]
    [StringLength(255)]
    public string DATA_SAIDA { get; set; }

    [StringLength(255)]
    public string STATUS { get; set; }

    [Column("PERCENTUAL FERIAS")]
    public double? PERCENTUAL_FERIAS { get; set; }

    [Column("NOME GERENTE")]
    [StringLength(255)]
    public string NOME_GERENTE { get; set; }

    [StringLength(255)]
    public string CLUSTER { get; set; }

    [StringLength(255)]
    public string CIDADE { get; set; }

    [StringLength(255)]
    public string COORDENADOR { get; set; }

    [StringLength(255)]
    public string CONSULTOR { get; set; }

    [Column("VENDEDOR INSTÂNCIA")]
    [StringLength(255)]
    public string VENDEDOR_INSTÂNCIA { get; set; }

    [Column("CANAL DE VENDAS")]
    [StringLength(255)]
    public string CANAL_DE_VENDAS { get; set; }

    [Column("GRUPO CANAL")]
    [StringLength(255)]
    public string GRUPO_CANAL { get; set; }

    [Column("GRUPO CANAL 2")]
    [StringLength(255)]
    public string GRUPO_CANAL_2 { get; set; }

    [StringLength(255)]
    public string REGIONAIS { get; set; }

    [Column("REGIONAL/TELE")]
    [StringLength(255)]
    public string REGIONAL_TELE { get; set; }

    [Column("LOGIN COORDENADOR")]
    [StringLength(255)]
    public string LOGIN_COORDENADOR { get; set; }

    [Column("LOGIN GERENTE")]
    [StringLength(255)]
    public string LOGIN_GERENTE { get; set; }

    [Column("LOGIN DIRETOR")]
    [StringLength(255)]
    public string LOGIN_DIRETOR { get; set; }

    [Column("NOME DIRETOR")]
    [StringLength(255)]
    public string NOME_DIRETOR { get; set; }

    [StringLength(255)]
    public string GRUPOS { get; set; }

    [StringLength(255)]
    public string CONTRATO { get; set; }

    public double? SEGUNDO_LOGIN { get; set; }

    [Column("ADABAS MÓVEL")]
    [StringLength(255)]
    public string ADABAS_MÓVEL { get; set; }

    [Column("ADABAS FIXA")]
    [StringLength(255)]
    public string ADABAS_FIXA { get; set; }

    public double? RECEBEDOR_SAP { get; set; }

    [StringLength(255)]
    public string GRUPO { get; set; }
}