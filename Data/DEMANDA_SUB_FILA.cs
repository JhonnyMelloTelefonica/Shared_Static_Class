﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("DEMANDA_SUB_FILA")]
[Index("ID_TIPO_FILA", Name = "IX_DEMANDA_SUB_FILA_ID_TIPO_FILA")]
public partial class DEMANDA_SUB_FILA
{
    [Key]
    public int ID_SUB_FILA { get; set; }

    [Required]
    [Unicode(false)]
    public string NOME_SUB_FILA { get; set; }

    [Required]
    [Unicode(false)]
    public string REGIONAL { get; set; }

    public bool CAMPOS_AUTO { get; set; }

    public bool CAMPOS_IDENT_USER { get; set; }

    public bool STATUS_SUB_FILA { get; set; }

    public int? MAT_CRIADOR { get; set; }

    public int ID_TIPO_FILA { get; set; }

    [Unicode(false)]
    public string DATA_CRIACAO { get; set; }

    public int? ID_ANTIGO { get; set; }

    [Unicode(false)]
    public string DESCRICAO { get; set; }

    public int SLA { get; set; }

    [InverseProperty("ID_SUB_FILANavigation")]
    public virtual ICollection<DEMANDA_CAMPOS_FILA> DEMANDA_CAMPOS_FILAs { get; set; } = new List<DEMANDA_CAMPOS_FILA>();

    [InverseProperty("ID_SUB_FILANavigation")]
    public virtual ICollection<DEMANDA_RESPONSAVEL_FILA> DEMANDA_RESPONSAVEL_FILAs { get; set; } = new List<DEMANDA_RESPONSAVEL_FILA>();

    [InverseProperty("Fila")]
    public virtual ICollection<DEMANDA_CHAMADO> DEMANDAS { get; set; }

    [ForeignKey("ID_TIPO_FILA")]
    [InverseProperty("DEMANDA_SUB_FILAs")]
    public virtual DEMANDA_TIPO_FILA ID_TIPO_FILANavigation { get; set; }

}