﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_ITEM_VENDA_ALTA")]
public partial class BOLETA_ITEM_VENDA_ALTum
{
    [Key]
    public int Id { get; set; }

    public int IdVenda { get; set; }

    [Unicode(false)]
    public string Produto { get; set; }

    [Unicode(false)]
    public string SubProduto { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string D0 { get; set; }

    [Unicode(false)]
    public string Plano1 { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Valor1 { get; set; }

    [Unicode(false)]
    public string Plano2 { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Valor2 { get; set; }

    [Unicode(false)]
    public string Plano3 { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Valor3 { get; set; }

    [Unicode(false)]
    public string DataVencimento { get; set; }

    public bool? Portabilidade { get; set; }

    public bool? MigracaoTecnologia { get; set; }

    public bool? OfertaConvergente { get; set; }

    public bool? ComFidelizacao { get; set; }

    [Unicode(false)]
    public string Device { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? ValorFidelizacaoDevice { get; set; }

    [Unicode(false)]
    public string IMEI { get; set; }

    [Unicode(false)]
    public string ICCID { get; set; }

    [Unicode(false)]
    public string CodFatIMEI { get; set; }

    [Unicode(false)]
    public string CodFatICCID { get; set; }

    [Unicode(false)]
    public string CodMaterial { get; set; }

    [Unicode(false)]
    public string ProtocoloGed { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string LinhaProvisoria { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string STATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCadastro { get; set; }

    [Unicode(false)]
    public string Linha { get; set; }

    [Unicode(false)]
    public string CodMaterialChip { get; set; }

    [InverseProperty("IDITEMVENDANavigation")]
    public virtual ICollection<BOLETA_CHECKLIST_QUALIDADE_VENDA_ALTum> BOLETA_CHECKLIST_QUALIDADE_VENDA_ALTa { get; set; } = new List<BOLETA_CHECKLIST_QUALIDADE_VENDA_ALTum>();

    [ForeignKey("IdVenda")]
    [InverseProperty("BOLETA_ITEM_VENDA_ALTa")]
    public virtual BOLETA_VENDum IdVendaNavigation { get; set; }
}