﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("EMAIL_CONTROLE_DEMANDAS")]
public partial class EMAIL_CONTROLE_DEMANDA
{
    public int ID { get; set; }

    public int? IDCHAMADO { get; set; }

    [Unicode(false)]
    public string EMAIL { get; set; }

    [Unicode(false)]
    public string TIPO_CHAMADO { get; set; }

    [Unicode(false)]
    public string REDE_LOJA { get; set; }

    [Unicode(false)]
    public string STATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_ENVIO_EMAIL { get; set; }
}