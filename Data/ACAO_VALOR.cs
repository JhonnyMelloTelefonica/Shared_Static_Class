﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("ACAO_VALOR")]
public partial class ACAO_VALOR
{
    [Key]
    public int ID { get; set; }

    public int IDVPC { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal VALOR { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string ORIGEM_VERBA { get; set; }

    public string REDE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string REGIONAL { get; set; }
}