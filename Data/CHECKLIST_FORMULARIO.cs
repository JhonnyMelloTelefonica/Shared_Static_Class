﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("CHECKLIST_FORMULARIO")]
public partial class CHECKLIST_FORMULARIO
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string Pergunta { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Peso { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string Formulario { get; set; }
}