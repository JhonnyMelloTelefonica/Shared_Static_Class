﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("DADOS_PESSOAIS_TERCEIROS")]
public partial class DADOS_PESSOAIS_TERCEIRO
{
    public int id { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string Cpf { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Sexo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Matricula { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string PrimeiroNome { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string SobreNome { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string NomeMae { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Funcao { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string Rg { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string OrgaoEmissor { get; set; }

    [Required]
    [StringLength(10)]
    [Unicode(false)]
    public string DataNasc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PIS { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string EMAILPESSOAL { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string GESTORLIDER { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string TELEFONEPESSOAL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string REGIONAL { get; set; }
}