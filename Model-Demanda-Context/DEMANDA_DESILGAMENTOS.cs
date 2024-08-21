﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PropertyChanged;
using Shared_Static_Class.Converters;

namespace Shared_Static_Class.Data;

[Table("DEMANDA_DESLIGAMENTOS", Schema = "Demandas")]
[AddINotifyPropertyChangedInterface]
public partial class DEMANDA_DESLIGAMENTOS
{
    [Key]
    public int ID { get; set; }
    public Guid ID_RELACAO { get; set; }
    public int MATRICULA_SOLICITANTE { get; set; }
    public int? MATRICULA_RESPONSAVEL { get; set; } = null;
    public DateTime DATA_ABERTURA { get; set; }
    public string REGIONAL { get;  set; }
    public void SetPrivateData(string regional, DateTime Hora, int matricula)
    {
        MATRICULA_SOLICITANTE = matricula;
        REGIONAL = regional;
        DATA_ABERTURA = Hora;
    }

    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public int Matricula { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Nome { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Cpf
    {
        get => _cpf;
        set
        {
            _cpf = FormatInputs.FormatCPF(value);
        }
    }
    private string _cpf = string.Empty;

    [ForeignKey("ID_RELACAO")]
    public virtual DEMANDA_RELACAO_CHAMADO Relacao { get; set; } = new();

    [ForeignKey("MATRICULA_SOLICITANTE")]
    public virtual ACESSOS_MOBILE Solicitante { get; set; }
    [ForeignKey("MATRICULA_RESPONSAVEL")]
    public virtual ACESSOS_MOBILE? Responsavel { get; set; }
}
