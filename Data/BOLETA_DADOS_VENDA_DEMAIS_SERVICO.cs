﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_DADOS_VENDA_DEMAIS_SERVICOS")]
public partial class BOLETA_DADOS_VENDA_DEMAIS_SERVICO
{
    [Key]
    public int Id { get; set; }

    public int? Id_Dados { get; set; }

    public int? Id_Venda { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string IMEI { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ICCID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string Material { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string Faturamento { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string ProtocoloGED { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string LinhaChip { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string CodFatChip { get; set; }
}