﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("VIVO_VISITA_EVIDENCIAS")]
public partial class VIVO_VISITA_EVIDENCIA
{
    [Key]
    public int ID { get; set; }

    public int? ID_CHECKLIST_PEX { get; set; }

    public byte[] IMAGEM { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string NOME_ARQUIVO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string EXTENSAO { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string TIPO_ABERTURA { get; set; }
}