﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("RELATORIO_SIGTM_SUL")]
public partial class RELATORIO_SIGTM_SUL
{
    [Key]
    public int ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LOGIN { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string MUNICIPIO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RETORNO { get; set; }
}