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

[Table("PRODUTOS_CARDAPIO", Schema = "Cardapio")]
public partial class PRODUTOS_CARDAPIO
{
    public PRODUTOS_CARDAPIO()
    {
    }

    public PRODUTOS_CARDAPIO(string nome, string descrição,List<ARGUMENTACAO_OURO> aRGUMENTACAO, PRODUTO_AVALIACAO avaliacao, Categoria_Produto categoria, string fabricante, string cor, bool isOferta, decimal valor, int maxParcelas, int maxParcelasSemJuros, DateTime dATA_INCLUSÃO, DateTime dATA_MODIFICAÇÃO, int mAT_INCLUSÃO, int mAT_MODIFICAÇÃO, List<FICHA_TECNICA> ficha, List<PRODUTO_IMAGEM> imagens, Guid? id_produto = null)
    {
        ID_PRODUTO = id_produto ?? Guid.Empty;
        Nome = nome;
        Descrição = descrição;
        Avaliacao = avaliacao ?? new(0, false, 0, null, null);
        Argumentacao = aRGUMENTACAO;
        Categoria_Produto = categoria;
        Fabricante = fabricante;
        Cor = cor;
        IsOferta = isOferta;
        Valor = valor;
        MaxParcelas = maxParcelas;
        MaxParcelasSemJuros = maxParcelasSemJuros;
        DATA_INCLUSÃO = dATA_INCLUSÃO;
        DATA_MODIFICAÇÃO = dATA_MODIFICAÇÃO;
        MAT_INCLUSÃO = mAT_INCLUSÃO;
        MAT_MODIFICAÇÃO = mAT_MODIFICAÇÃO;
        Ficha = ficha;
        Imagens = imagens;
    }

    [Key]
    public Guid ID_PRODUTO { get; set; }
    [MaxLength(255)]
    public string Nome { get; set; }
    [MaxLength(1200)]
    public string Descrição { get; set; }
    public Categoria_Produto Categoria_Produto { get; set; }
    public string Fabricante { get; set; }
    public string Cor { get; set; }
    public bool IsOferta { get; set; } = false;
    [Precision(18, 2)]
    public decimal Valor { get; set; } = 0;
    public int MaxParcelas { get; set; } = 0;
    public int MaxParcelasSemJuros { get; set; } = 0;
    public DateTime DATA_INCLUSÃO { get; set; }
    public DateTime DATA_MODIFICAÇÃO { get; set; }
    public int MAT_INCLUSÃO { get; set; }
    public int MAT_MODIFICAÇÃO { get; set; }
    public ACESSOS_MOBILE Responsavel_Inclusao { get; set; }
    public ACESSOS_MOBILE Responsavel_Modificacao { get; set; }
    public List<FICHA_TECNICA> Ficha { get; set; } = [];
    public List<PRODUTO_IMAGEM> Imagens { get; set; } = [];
    public List<ARGUMENTACAO_OURO> Argumentacao { get; set; } = [];
    public PRODUTO_AVALIACAO Avaliacao { get; set; }
}

public enum Categoria_Produto
{
    SMARTPHONE,
    NOTEBOOK,
    CONSOLE,
    CASA_INTELIGENTE,
    GAMES,
    CUIDADO_PESSOAL,
    MODA,
    ACESSÓRIOS,
    AÚDIO_VÍDEO
}
