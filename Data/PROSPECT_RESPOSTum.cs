﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("PROSPECT_RESPOSTA")]
public partial class PROSPECT_RESPOSTum
{
    [Key]
    public int ID { get; set; }

    [Required]
    [Unicode(false)]
    public string RESPOSTA { get; set; }

    public int IDPROSPECT { get; set; }

    [Unicode(false)]
    public string MATRICULA_RESPONSAVEL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_RESPOSTA { get; set; }

    [Unicode(false)]
    public string STATUS { get; set; }

    [ForeignKey("IDPROSPECT")]
    [InverseProperty("PROSPECT_RESPOSTa")]
    public virtual CREDENCIAMENTO_PROSPECT IDPROSPECTNavigation { get; set; }

    [InverseProperty("ID_RESPOSTANavigation")]
    public virtual ICollection<PROSPECT_ARQUIVOS_RESPOSTum> PROSPECT_ARQUIVOS_RESPOSTa { get; set; } = new List<PROSPECT_ARQUIVOS_RESPOSTum>();
}