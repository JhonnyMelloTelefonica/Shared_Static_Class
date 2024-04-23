﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("HISTORICO_ACESSOS_MOBILE_PENDENTE")]
public partial class HISTORICO_ACESSOS_MOBILE_PENDENTE
{
    [Key]
    public int ID { get; set; }

    public int ID_ACESSOS_PENDENTE { get; set; }

    public int? MATRICULA { get; set; }

    [Required]
    [Unicode(false)]
    public string RESPOSTA { get; set; }

    [Required]
    [StringLength(100)]
    [Unicode(false)]
    public string STATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA { get; set; }
}