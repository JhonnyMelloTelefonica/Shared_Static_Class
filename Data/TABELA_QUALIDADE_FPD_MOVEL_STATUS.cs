﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("TABELA_QUALIDADE_FPD_MOVEL_STATUS")]
public partial class TABELA_QUALIDADE_FPD_MOVEL_STATUS
{
    [Key]
    public int Id { get; set; }

    public int IdFPD { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string OBSERVACAO { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string RETORNO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DATA_ULTIMA_ALTERACAO { get; set; }

    public int ID_SOLICITANTE_ALTERACAO { get; set; }

    [ForeignKey("IdFPD")]
    [InverseProperty("TABELA_QUALIDADE_FPD_MOVEL_STATUSes")]
    public virtual TABELA_QUALIDADE_FPD_MOVEL IdFPDNavigation { get; set; }
}