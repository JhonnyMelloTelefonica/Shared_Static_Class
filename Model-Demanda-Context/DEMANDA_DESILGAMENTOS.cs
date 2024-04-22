﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Shared_Static_Class.Data;

[Table("DEMANDA_DESLIGAMENTOS", Schema = "Demandas")]
public partial class DEMANDA_DESLIGAMENTOS
{
    [Key]
    public int ID { get; set; }
    [Required]
    public Guid ID_RELACAO { get; set; }
    public int MATRICULA_SOLICITANTE { get; set; }
    public string UF { get; set; }
    public string DDD { get; set; }
    public string NOME_FUNCIONARIO { get; set; }
    public string MATRICULA_FUNCIONARIO { get; set; }
    public string LOGIN_FUNCIONARIO { get; set; }
    public DateTime? DATA_CADASTRO_DESLIGAMENTO { get; set; }
    public string CONFIRMA_DESLIGAMENTO { get; set; }
    public DateTime? DATA_CONFIRMA_DESLIGAMENTO { get; set; }
    public string USUARIO { get; set; }
    public string CPF { get; set; }
    public string ADABAS { get; set; }
    public string MOTIVO { get; set; }
    public string REGIONAL { get; set; }

    [ForeignKey("ID_RELACAO")]
    [Required]
    [JsonIgnore]
    public virtual DEMANDA_RELACAO_CHAMADO Relacao { get; set; }

    [ForeignKey("MATRICULA_SOLICITANTE")]
    public virtual ACESSOS_MOBILE Solicitante { get; set; }
}
