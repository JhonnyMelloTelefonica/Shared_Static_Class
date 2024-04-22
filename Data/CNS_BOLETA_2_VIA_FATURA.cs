﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
public partial class CNS_BOLETA_2_VIA_FATURA
{
    public int IdVenda { get; set; }

    public int? DIA { get; set; }

    [Column("Data Completa 2 Via", TypeName = "datetime")]
    public DateTime? Data_Completa_2_Via { get; set; }

    [Column("Data 2 Via", TypeName = "datetime")]
    public DateTime? Data_2_Via { get; set; }

    [Required]
    [Column("HH:MM")]
    [StringLength(14)]
    [Unicode(false)]
    public string HH_MM { get; set; }

    [Column("Qtd 2 Via Fatura")]
    public int Qtd_2_Via_Fatura { get; set; }
}