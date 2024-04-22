﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("CARTEIRA_DEMAIS_CANAIS")]
public partial class CARTEIRA_DEMAIS_CANAI
{
    [StringLength(255)]
    public string Cnpj { get; set; }

    [StringLength(255)]
    public string RazaoSocial { get; set; }

    [StringLength(255)]
    public string NomeFantasia { get; set; }

    [StringLength(255)]
    public string Uf { get; set; }

    [StringLength(255)]
    public string GA { get; set; }

    [StringLength(255)]
    public string GGP { get; set; }

    [StringLength(255)]
    public string StatusCallidus { get; set; }

    [StringLength(255)]
    public string Vendedor { get; set; }

    [StringLength(255)]
    public string REDE { get; set; }

    [StringLength(255)]
    public string Canal { get; set; }

    [StringLength(255)]
    public string DDD_LOCALIDADE_PDV { get; set; }

    [StringLength(255)]
    public string Atividade { get; set; }

    [StringLength(255)]
    public string AREA_ATUACAO_DDD { get; set; }

    [StringLength(255)]
    public string GV { get; set; }

    [StringLength(255)]
    public string LoginSiebel { get; set; }

    [StringLength(255)]
    public string Cidade { get; set; }

    [StringLength(255)]
    public string Bairro { get; set; }

    [StringLength(255)]
    public string Cep { get; set; }

    [StringLength(255)]
    public string Endereco { get; set; }

    [StringLength(255)]
    public string Numero { get; set; }

    [StringLength(255)]
    public string Complemento { get; set; }

    [StringLength(255)]
    public string Data_Credenciamento { get; set; }

    [StringLength(255)]
    public string Data_Descredenciamento { get; set; }

    [StringLength(255)]
    public string Modelo_Loja { get; set; }

    [StringLength(255)]
    public string Tipo_Loja { get; set; }

    [StringLength(255)]
    public string Local_Loja { get; set; }

    [StringLength(255)]
    public string GSS { get; set; }

    [StringLength(255)]
    public string Clusters { get; set; }

    [StringLength(255)]
    public string Estrelagem { get; set; }

    [StringLength(255)]
    public string MT { get; set; }

    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ANOMES { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataUltimaAlteracao { get; set; }

    public int? idAcesso { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataSolicitacao { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DivisaoOrig { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MATRICULA_GV { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MATRICULA_GA { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MATRICULA_GGP { get; set; }

    public bool? ANOMES_ATUAL { get; set; }

    [StringLength(30)]
    public string QtdPA { get; set; }

    [StringLength(30)]
    public string Metragem { get; set; }
}