﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("ACAO_TIPO_MIDIA")]
public partial class ACAO_TIPO_MIDIum
{
    [Key]
    public int idTipo { get; set; }

    [Required]
    [StringLength(150)]
    [Unicode(false)]
    public string Descricao { get; set; }
}