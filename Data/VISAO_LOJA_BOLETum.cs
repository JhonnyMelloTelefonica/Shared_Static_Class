﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("VISAO_LOJA_BOLETA")]
public partial class VISAO_LOJA_BOLETum
{
    [StringLength(50)]
    [Unicode(false)]
    public string MATRICULA { get; set; }
}