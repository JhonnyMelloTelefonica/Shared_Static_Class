﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("DESCREDENCIAMENTO_AMIGAVEL OLD")]
public partial class DESCREDENCIAMENTO_AMIGAVEL_OLD
{
    [Key]
    public int ID { get; set; }

    public int ID_DESCREDENCIAMENTO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SOLICITACAO_PARCEIRO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_SOLICITACAO_PARCEIRO { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string INFORME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LIBERADO_CHANCELA { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_LIBERADO_CHANCELA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DATA_CHANCELA_DISTRATO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ENVIO_TERRITORIO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_ENVIO_TERRITORIO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RECEBIMENTO_DISTRATO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_RECEBIMENTO_DISTRATO { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string STATUS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ASSINATURA_DIVISAO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_ASSINATURA_DIVISAO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ASSINATURA_DIRETORIA { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_ASSINATURA_DIRETORIA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RECONHECIMENTO_FIRMA { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_RECONHECIMENTO_FIRMA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string EXCLUSAO_ACESSOS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_EXCLUSAO_ACESSOS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_ALTERACAO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DATA_ENVIO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DATA_RECEBIMENTO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string EMISSAO_NOTIFICACAO { get; set; }

    [Unicode(false)]
    public string OBSERVACAO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DATA_SOLIC_DESCREDENCIAMENTO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DATA_CONFIRMACAO_DESCREDENCIAMENTO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string DATA_PREVISTA_DESCREDENCIAMENTO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA_DATA_PREVISTA_DESCREDENCIAMENTO { get; set; }

    [ForeignKey("ID_DESCREDENCIAMENTO")]
    [InverseProperty("DESCREDENCIAMENTO_AMIGAVEL_OLDs")]
    public virtual DESCREDENCIAMENTO_CADASTRO ID_DESCREDENCIAMENTONavigation { get; set; }
}