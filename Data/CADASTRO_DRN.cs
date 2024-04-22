﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("CADASTRO_DRN")]
public partial class CADASTRO_DRN
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NrDRN { get; set; }

    [Column(TypeName = "text")]
    public string RazaoSocial { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TipoResposta { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string Canal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Minuta { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string Socio1 { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string Socio2 { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string Socio3 { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string Socio4 { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string SocioADM1 { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string SocioADM2 { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string SocioADM3 { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string SocioADM4 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCadastro { get; set; }

    public int? idAcesso { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Cnpj { get; set; }
}