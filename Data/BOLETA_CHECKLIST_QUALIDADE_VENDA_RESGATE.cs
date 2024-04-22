﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("BOLETA_CHECKLIST_QUALIDADE_VENDA_RESGATE")]
public partial class BOLETA_CHECKLIST_QUALIDADE_VENDA_RESGATE
{
    [Key]
    public int ID { get; set; }

    public int IDVENDA { get; set; }

    public int IDITEMVENDA { get; set; }

    public bool? GED { get; set; }

    public bool? ALTAS_SEM_TRAFEGO { get; set; }

    public bool? DEPENDENTE_SEM_TITULAR { get; set; }

    public bool? PGTO_FATURA_1 { get; set; }

    public bool? PGTO_FATURA_2 { get; set; }

    public bool? PGTO_FATURA_3 { get; set; }

    public bool? PGTO_FATURA_4 { get; set; }

    public bool? PGTO_FATURA_5 { get; set; }

    public bool? PGTO_FATURA_6 { get; set; }

    public bool? TELEFONE_CONTATO { get; set; }

    public bool? EMAIL_CONTATO { get; set; }

    public bool? COD { get; set; }

    public bool? DALTO { get; set; }

    public bool? DENTRO_DA_CONTA { get; set; }

    [ForeignKey("IDITEMVENDA")]
    [InverseProperty("BOLETA_CHECKLIST_QUALIDADE_VENDA_RESGATEs")]
    public virtual BOLETA_ITEM_VENDA_RESGATE IDITEMVENDANavigation { get; set; }

    [ForeignKey("IDVENDA")]
    [InverseProperty("BOLETA_CHECKLIST_QUALIDADE_VENDA_RESGATEs")]
    public virtual BOLETA_VENDum IDVENDANavigation { get; set; }
}