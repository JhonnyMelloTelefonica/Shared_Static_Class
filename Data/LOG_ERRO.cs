﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("LOG_ERROS")]
public partial class LOG_ERRO
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    public string USUARIO_REDE { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string MATRICULA { get; set; }

    [Required]
    [Unicode(false)]
    public string ERRO { get; set; }

    [Required]
    [Unicode(false)]
    public string OPERACAO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DATA { get; set; }
}