﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
public partial class CNS_CTRL_DEMANDA_ULTIMO_STATUS
{
    public int ID_STATUS_CHAMADO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATA { get; set; }
}