﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("PROSPECT_ARQUIVOS_RESPOSTA")]
public partial class PROSPECT_ARQUIVOS_RESPOSTum
{
    [Key]
    public int ID { get; set; }

    public int ID_RESPOSTA { get; set; }

    [Unicode(false)]
    public string NOME_CAMPO { get; set; }

    public byte[] ARQUIVO { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string EXT_ARQUIVO { get; set; }

    [ForeignKey("ID_RESPOSTA")]
    [InverseProperty("PROSPECT_ARQUIVOS_RESPOSTa")]
    public virtual PROSPECT_RESPOSTum ID_RESPOSTANavigation { get; set; }
}