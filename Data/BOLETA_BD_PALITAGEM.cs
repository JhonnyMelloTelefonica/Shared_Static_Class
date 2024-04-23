﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_BD_PALITAGEM")]
public partial class BOLETA_BD_PALITAGEM
{
    [Key]
    public int ID_BOLETA { get; set; }

    public int MAT_CONSULTOR { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DATA_INICIO { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? TOTAL_PAGAMENTO { get; set; }

    public int? MET_PAGAMENTO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DT_PRIMEIRO_RETORNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string STATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DT_RETORNO { get; set; }

    public int? MAT_ANALISTA { get; set; }

    [Required]
    [StringLength(100)]
    [Unicode(false)]
    public string PDV { get; set; }

    public int ID_BOLETA_PDV { get; set; }

    [InverseProperty("ID_BOLETANavigation")]
    public virtual ICollection<BOLETA_BD_BLOCAO> BOLETA_BD_BLOCAOs { get; set; } = new List<BOLETA_BD_BLOCAO>();

    [InverseProperty("ID_BOLETANavigation")]
    public virtual ICollection<BOLETA_BD_CLIENTE> BOLETA_BD_CLIENTEs { get; set; } = new List<BOLETA_BD_CLIENTE>();

    [InverseProperty("ID_BOLETANavigation")]
    public virtual ICollection<HISTORICO_BOLETA_BD_PALITAGEM> HISTORICO_BOLETA_BD_PALITAGEMs { get; set; } = new List<HISTORICO_BOLETA_BD_PALITAGEM>();
}