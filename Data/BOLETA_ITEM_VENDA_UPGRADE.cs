﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_ITEM_VENDA_UPGRADE")]
public partial class BOLETA_ITEM_VENDA_UPGRADE
{
    [Key]
    public int Id { get; set; }

    public int IdVenda { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string LinhaUpgrade { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? ValorUpgrade { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCadastro { get; set; }

    [Unicode(false)]
    public string PlanoAnterior { get; set; }

    [Unicode(false)]
    public string ProtocoloGed { get; set; }

    [Unicode(false)]
    public string MaiorMenor120Dias { get; set; }

    [InverseProperty("IDITEMVENDANavigation")]
    public virtual ICollection<BOLETA_CHECKLIST_QUALIDADE_VENDA_UPGRADE> BOLETA_CHECKLIST_QUALIDADE_VENDA_UPGRADEs { get; set; } = new List<BOLETA_CHECKLIST_QUALIDADE_VENDA_UPGRADE>();

    [ForeignKey("IdVenda")]
    [InverseProperty("BOLETA_ITEM_VENDA_UPGRADEs")]
    public virtual BOLETA_VENDum IdVendaNavigation { get; set; }
}