﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("MARGEM REVENDA PRE")]
public partial class MARGEM_REVENDA_PRE
{
    [StringLength(255)]
    public string UF { get; set; }

    [Column("Nome DPGC")]
    [StringLength(255)]
    public string Nome_DPGC { get; set; }

    [Column("Nome Comercial")]
    [StringLength(255)]
    public string Nome_Comercial { get; set; }

    [StringLength(255)]
    public string Fabricante { get; set; }

    [Column("Grupo Margem Pré")]
    [StringLength(255)]
    public string Grupo_Margem_Pré { get; set; }

    [Column("Margem Líquida Outubro/18")]
    public double? Margem_Líquida_Outubro_18 { get; set; }

    [StringLength(255)]
    public string COD_MAT { get; set; }
}