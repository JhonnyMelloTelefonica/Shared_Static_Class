﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("CASO_NAO")]
public partial class CASO_NAO
{
    [StringLength(25)]
    public string Vendedor { get; set; }

    [StringLength(14)]
    public string Login { get; set; }
}