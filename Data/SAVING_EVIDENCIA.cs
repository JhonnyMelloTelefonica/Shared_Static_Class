﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("SAVING_EVIDENCIAS")]
public partial class SAVING_EVIDENCIA
{
    [Key]
    public int ID { get; set; }

    public int ID_SAVING { get; set; }

    public byte[] IMAGEM { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string NOME_ARQUIVO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string EXTENSAO { get; set; }

    [ForeignKey("ID_SAVING")]
    [InverseProperty("SAVING_EVIDENCIAs")]
    public virtual SAVING_CADASTRO ID_SAVINGNavigation { get; set; }
}