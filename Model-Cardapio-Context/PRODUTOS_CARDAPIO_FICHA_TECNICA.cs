﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Newtonsoft.Json;
using Shared_Static_Class.Model_Demanda_Context;
using Shared_Static_Class.Model_DTO;

namespace Shared_Static_Class.Data;

[Table("PRODUTOS_CARDAPIO_FICHA_TECNICA", Schema = "Cardapio")]
public partial class FICHA_TECNICA
{
    public FICHA_TECNICA()
    {
    }

    public FICHA_TECNICA(string especificação, string valor, bool isImportant, bool isInfoAdicional, Categoria_Especificação categoria, Tipo_Valor_Ficha Tipovalor , Guid? id_produto = null)
    {
        TipoValor = Tipovalor;
        ID_PRODUTO = id_produto ?? Guid.Empty;
        Especificação = especificação;
        Valor = valor;
        IsImportant = isImportant;
        IsInfoAdicional = isInfoAdicional;
        Categoria_Especificação = categoria;
    }

    [Key]
    public Guid ID_FICHA { get; set; }
    public Guid ID_PRODUTO { get; set; }
    public string Especificação { get; set; }
    public Categoria_Especificação Categoria_Especificação { get; set; } = Categoria_Especificação.GENÉRICO;
    public string Valor { get; set; }
    public bool IsImportant { get; set; } = false;
    public bool IsInfoAdicional { get; set; } = false;
    public Tipo_Valor_Ficha TipoValor { get; set; } = Tipo_Valor_Ficha.STRING;
    public PRODUTOS_CARDAPIO Produto { get; set; }   
}
public enum Tipo_Valor_Ficha
{
    STRING,
    NUMERO,
    BOOLEANO
}

public enum Categoria_Especificação
{
    REDE,
    TELA,
    CÂMERA, 
    VÍDEO,
    CONECTIVIDADE,
    SENSORES,
    FUNÇÕES,
    BATERIA,
    ARMAZENAMENTO,
    PROCESSADOR,
    GENÉRICO
}
