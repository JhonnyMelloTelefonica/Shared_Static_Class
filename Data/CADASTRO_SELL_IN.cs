﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("CADASTRO_SELL_IN")]
public partial class CADASTRO_SELL_IN
{
    [Key]
    public int ID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string NOME_REDE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string SELL_IN { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string DATA_EFETIVACAO { get; set; }
}