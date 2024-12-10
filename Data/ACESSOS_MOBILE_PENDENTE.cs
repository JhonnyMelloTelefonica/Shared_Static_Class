﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("ACESSOS_MOBILE_PENDENTE")]
public partial class ACESSOS_MOBILE_PENDENTE
{
    [Key]
    public int ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string EMAIL { get; set; }

    public int? MATRICULA { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string SENHA { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string REGIONAL { get; set; }

    public int CARGO { get; set; }

    public int CANAL { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    [DefaultValue("(00) 00000-0000")]
    public string? TELEFONE { get; set; } = "(00) 00000-0000";

    [Unicode(false)]
    public string NOME { get; set; }
    public string NOME_SOCIAL { get; set; }

    [Unicode(false)]
    public string UF { get; set; }

    public bool? APROVACAO { get; set; }

    public bool? FIXA { get; set; }

    public int? LOGIN_SOLICITANTE { get; set; }

    public int? LOGIN_RESPONSAVEL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DT_SOLICITACAO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DT_RETORNO { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string STATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DT_PRIMEIRO_RETORNO { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string CPF { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PDV { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TIPO { get; set; }

    public int? ID_ACESSOS_MOBILE { get; set; }

    public bool? STATUS_USUARIO { get; set; }

    public int? DDD { get; set; }

    public int? TP_STATUS { get; set; }

    public bool? ELEGIVEL { get; set; }

    public byte[] UserAvatar { get; set; }

    public ACESSOS_MOBILE Solicitante { get; set; } = null;
}