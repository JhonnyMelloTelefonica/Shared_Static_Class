﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_BD_LINHA")]
public partial class BOLETA_BD_LINHA
{
    [Key]
    public int ID_LINHA_BOLETA { get; set; }

    public int ID_DADOS_BOLETA { get; set; }

    public int? NUMERO_LINHA { get; set; }

    public int? NUMERO_PROVISORIO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ICCID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string MATERIAL { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string FATURAMENTO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NOTA_FISCAL { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? VALOR { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_VENC_FAT { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string OPERA_DOA { get; set; }

    [ForeignKey("ID_DADOS_BOLETA")]
    [InverseProperty("BOLETA_BD_LINHAs")]
    public virtual BOLETA_BD_DADO ID_DADOS_BOLETANavigation { get; set; }
}