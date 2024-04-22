﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("ACAO_HISTORICO")]
public partial class ACAO_HISTORICO
{
    [Key]
    public int ID { get; set; }

    public int IDVPC { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LIBERACAO_VERBA { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CADASTRO_ACAO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VALIDACAO_MKT_TERRITORIAL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VALIDACAO_MKT_REGIONAL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? APROVACAO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RETORNAR_GC { get; set; }

    [ForeignKey("IDVPC")]
    [InverseProperty("ACAO_HISTORICOs")]
    public virtual ACAO_CADASTRO IDVPCNavigation { get; set; }
}