﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_DADOS_DEMAIS_SERVICOS")]
public partial class BOLETA_DADOS_DEMAIS_SERVICO
{
    [Key]
    public int Id { get; set; }

    public int? Id_Dados { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string Tipo_Boleta { get; set; }

    [StringLength(350)]
    [Unicode(false)]
    public string Plano { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string Device { get; set; }

    public double? Valor { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string Marca { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string MasterBox { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string ValorVoucher { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Linha { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string CorDevice { get; set; }
}