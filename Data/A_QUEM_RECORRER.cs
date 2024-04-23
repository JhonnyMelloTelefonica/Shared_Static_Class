﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("A_QUEM_RECORRER")]
public partial class A_QUEM_RECORRER
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string MATRICULA { get; set; }

    [Required]
    [StringLength(150)]
    [Unicode(false)]
    public string AREA { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    public string NOME { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    public string EMAIL { get; set; }

    [Required]
    [StringLength(150)]
    [Unicode(false)]
    public string CELULAR { get; set; }

    [Required]
    [StringLength(150)]
    [Unicode(false)]
    public string RAMAL { get; set; }

    [Required]
    [Unicode(false)]
    public string ATIVIDADES { get; set; }

    [Required]
    [StringLength(150)]
    [Unicode(false)]
    public string STATUS { get; set; }

    [Required]
    [StringLength(150)]
    [Unicode(false)]
    public string FUNCAO { get; set; }

    [Required]
    [StringLength(150)]
    [Unicode(false)]
    public string EXTENSAO { get; set; }

    public byte[] IMAGEM { get; set; }
}