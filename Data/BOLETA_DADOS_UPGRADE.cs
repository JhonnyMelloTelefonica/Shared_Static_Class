﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_DADOS_UPGRADE")]
public partial class BOLETA_DADOS_UPGRADE
{
    [Key]
    public int Id { get; set; }

    public int? Id_Dados { get; set; }

    public int? Id_Venda { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string MatriculaCN { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string IMEI { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string ICCID { get; set; }
}