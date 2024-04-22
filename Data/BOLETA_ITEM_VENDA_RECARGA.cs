﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_ITEM_VENDA_RECARGA")]
public partial class BOLETA_ITEM_VENDA_RECARGA
{
    [Key]
    public int Id { get; set; }

    public int IdVenda { get; set; }

    [Unicode(false)]
    public string Linha { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Valor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCadastro { get; set; }

    [ForeignKey("IdVenda")]
    [InverseProperty("BOLETA_ITEM_VENDA_RECARGAs")]
    public virtual BOLETA_VENDum IdVendaNavigation { get; set; }
}