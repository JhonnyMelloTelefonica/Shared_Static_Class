﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("CADASTRO_UNICO_ACESSO")]
public partial class CADASTRO_UNICO_ACESSO
{
    public int idAcesso { get; set; }

    [Required]
    [StringLength(14)]
    [Unicode(false)]
    public string Perfil { get; set; }
}