﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_ITEM_VENDA_RESGATE")]
public partial class BOLETA_ITEM_VENDA_RESGATE
{
    [Key]
    public int Id { get; set; }

    public int IdVenda { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string Linha { get; set; }

    [Unicode(false)]
    public string ICCID { get; set; }

    [Unicode(false)]
    public string CodFatICCID { get; set; }

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
    public string CodMaterial { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string PF_PJ { get; set; }

    [InverseProperty("IDITEMVENDANavigation")]
    public virtual ICollection<BOLETA_CHECKLIST_QUALIDADE_VENDA_RESGATE> BOLETA_CHECKLIST_QUALIDADE_VENDA_RESGATEs { get; set; } = new List<BOLETA_CHECKLIST_QUALIDADE_VENDA_RESGATE>();

    [ForeignKey("IdVenda")]
    [InverseProperty("BOLETA_ITEM_VENDA_RESGATEs")]
    public virtual BOLETA_VENDum IdVendaNavigation { get; set; }
}