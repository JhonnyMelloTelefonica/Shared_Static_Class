﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Shared_Static_Class.Data;

[Table("DEMANDA_AVALIACAO_ANALISTA", Schema = "Demandas")]
public partial class DEMANDA_AVALIACAO_ANALISTA
{
    [Key]
    public Guid ID { get; set; }
    public int MATRICULA_AVALIADOR { get; set; }
    public int MATRICULA_ANALISTA { get; set; }
    public int ID_CHAMADO { get; set; }
    public bool PROBLEMA_RESOLVIDO { get; set; }
    [Unicode(false)]
    [Range(0, 6, ErrorMessage = "Por favor informe uma nota")]
    public int AVALIACAO_ANALISTA { get; set; }
    [Unicode(false)]
    [Range(0, 6, ErrorMessage = "Por favor informe uma nota")]
    public int AVALIACAO_PLATAFORMA { get; set; }

    [Unicode(false)]
    public string? AVALIACAO_GERAL { get; set; } = string.Empty;

    [Column(TypeName = "datetime")]
    public DateTime DATA { get; set; }

    [ForeignKey("ID_CHAMADO")]
    [JsonIgnore]
    public virtual DEMANDA_CHAMADO DEMANDANav { get; set; }
}