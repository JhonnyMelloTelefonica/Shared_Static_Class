﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Keyless]
[Table("CONCORRENCIA_CLIENTE_TRIAGEM_CLIENTE_BOLETA")]
public partial class CONCORRENCIA_CLIENTE_TRIAGEM_CLIENTE_BOLETum
{
    public int ID { get; set; }

    public int ID_TRIAGEM { get; set; }

    [Unicode(false)]
    public string CONCORRENCIA { get; set; }

    [ForeignKey("ID_TRIAGEM")]
    public virtual TRIAGEM_CLIENTE_BOLETum ID_TRIAGEMNavigation { get; set; }
}