﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Compression;
using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Shared_Static_Class.Converters;
using Shared_Static_Class.Data;
using Shared_Static_Class.Model_Demanda_Context;

namespace Shared_Static_Class.DB_Context_Vivo_MAIS;

public partial class CardapioDigitalContext : DbContext
{
    public CardapioDigitalContext()
    {
    }

    public CardapioDigitalContext(DbContextOptions<CardapioDigitalContext> options)
        : base(options)
    {

    }

    public virtual DbSet<ACESSOS_MOBILE> ACESSOS_MOBILE { get; set; }
    public virtual DbSet<PERFIL_USUARIO> PERFIL_USUARIO { get; set; }
    public virtual DbSet<PRODUTOS_CARDAPIO> PRODUTOS_CARDAPIO { get; set; }
    public virtual DbSet<FICHA_TECNICA> FICHA_TECNICA { get; set; }
    public virtual DbSet<PRODUTO_IMAGEM> PRODUTO_IMAGENS { get; set; }
    public virtual DbSet<PRODUTO_AVALIACAO> PRODUTO_AVALIACAO { get; set; }
    public virtual DbSet<ARGUMENTACAO_OURO> ARGUMENTACAO_OURO { get; set; }
    public virtual DbSet<AVALIACAO_ARGUMENTACAO> AVALIACAO_ARGUMENTACAO { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        optionsBuilder.UseSqlServer("Data Source=10.124.100.153;Initial Catalog=Vivo_MAIS;TrustServerCertificate=True;User ID=RegionalNE;Password=RegionalNEvivo2019;MultipleActiveResultSets=true"
            , o =>
            {
                o.UseCompatibilityLevel(120);
                o.CommandTimeout(36000);
                o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                o.MigrationsHistoryTable("__EFMigrationsHistory", "Cardapio");
                o.MigrationsAssembly("Api Vivo Apps");
            });
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<ACESSOS_MOBILE>().ToTable("ACESSOS_MOBILE", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<PERFIL_USUARIO>().ToTable("PERFIL_USUARIO", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_SUB_FILA>().ToTable("DEMANDA_SUB_FILA", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_TIPO_FILA>().ToTable("DEMANDA_TIPO_FILA", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_CAMPOS_FILA>().ToTable("DEMANDA_CAMPOS_FILA", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_RESPONSAVEL_FILA>().ToTable("DEMANDA_RESPONSAVEL_FILA", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_VALORES_CAMPOS_SUSPENSO>().ToTable("DEMANDA_VALORES_CAMPOS_SUSPENSO", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_BD_OPERADORE>().ToTable("DEMANDA_BD_OPERADORES", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_RELACAO_CHAMADO>().ToTable("DEMANDA_RELACAO_CHAMADO", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_OBSERVACOES_ANALISTAS>().ToTable("DEMANDA_OBSERVACOES_ANALISTAS", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_DESLIGAMENTOS>().ToTable("DEMANDA_DESLIGAMENTOS", t => t.ExcludeFromMigrations());


        var produtoId = Guid.NewGuid();

        // Seed PRODUTOS_CARDAPIO
        modelBuilder.Entity<PRODUTOS_CARDAPIO>().HasData(
            new PRODUTOS_CARDAPIO
            {
                ID_PRODUTO = produtoId,
                Nome = "Samsung A54 5G",
                Descrição = "Apenas um Celular",
                Categoria_Produto = Categoria_Produto.SMARTPHONE,
                Fabricante = "Samsung",
                Cor = "Preta",
                IsOferta = false,
                Valor = 799.0m,
                MaxParcelas = 24,
                MaxParcelasSemJuros = 10,
                DATA_INCLUSÃO = DateTime.Now,
                DATA_MODIFICAÇÃO = DateTime.Now,
                MAT_INCLUSÃO = 151191,
                MAT_MODIFICAÇÃO = 151191
            });

        var argumentacao1 = Guid.NewGuid();
        var argumentacao2 = Guid.NewGuid();
        var argumentacao3 = Guid.NewGuid();
        var avaliacao = Guid.NewGuid();

        modelBuilder.Entity<PRODUTO_AVALIACAO>().HasData(
            new Data.PRODUTO_AVALIACAO
            {
                //(28, false, 52, produtoId)

                ID_AVALIACAO = avaliacao,
                ID_PRODUTO = produtoId,
                Avaliacao = 28,
                PositionInRank = 52,
            });



        modelBuilder.Entity<ARGUMENTACAO_OURO>().HasData(
            new Data.ARGUMENTACAO_OURO
            {
                ID_ARGUMENTACAO = argumentacao1,
                ID_PRODUTO = produtoId,
                Argumentacao = "Este produto é ótimo para jogos ou uso casual",
                IsGold = true,
                IsBadCaracter = false,
                MATRICULA_RESPONSAVEL = 151191,
                DT_MODIFICACAO = DateTime.Now
            },
            new Data.ARGUMENTACAO_OURO
            {
                ID_PRODUTO = produtoId,
                ID_ARGUMENTACAO = argumentacao2,
                Argumentacao = "Este produto é péssimo para realizar ligações, jogue este celular no lixo!!",
                IsGold = false,
                IsBadCaracter = false,
                MATRICULA_RESPONSAVEL = 151191,
                DT_MODIFICACAO = DateTime.Now
            },
            new Data.ARGUMENTACAO_OURO
            {
                ID_PRODUTO = produtoId,
                ID_ARGUMENTACAO = argumentacao3,
                Argumentacao = "Não é recomendado que utilize este produto para lavar a louça!",
                IsGold = true,
                IsBadCaracter = true,
                MATRICULA_RESPONSAVEL = 151191,
                DT_MODIFICACAO = DateTime.Now
            }
        );

        var avaliacaoargumentacao1 = Guid.NewGuid();
        var avaliacaoargumentacao2 = Guid.NewGuid();
        var avaliacaoargumentacao3 = Guid.NewGuid();

        modelBuilder.Entity<AVALIACAO_ARGUMENTACAO>().HasData(
            new Data.AVALIACAO_ARGUMENTACAO
            {
                ID_ARGUMENTACAO = argumentacao1,
                ID_AVALIACAO_ARGUMENTACAO = avaliacaoargumentacao1,
                Avaliacao = 97,
                IsUtil = true,
                MATRICULA_RESPONSAVEL = 25183,
                DT_MODIFICACAO = DateTime.Now
            },
            //new Data.AVALIACAO_ARGUMENTACAO { Avaliacao = 47, IsUtil = false, MATRICULA_RESPONSAVEL = 25183, DT_MODIFICACAO = DateTime.Now, ID_ARGUMENTACAO = argumentacao1, ID_AVALIACAO_ARGUMENTACAO = new Guid() },
            //new Data.AVALIACAO_ARGUMENTACAO { Avaliacao = 28, IsUtil = true, MATRICULA_RESPONSAVEL = 25183, DT_MODIFICACAO = DateTime.Now, ID_ARGUMENTACAO = argumentacao1, ID_AVALIACAO_ARGUMENTACAO = new Guid() },
            new Data.AVALIACAO_ARGUMENTACAO { Avaliacao = 85, IsUtil = false, MATRICULA_RESPONSAVEL = 25183, DT_MODIFICACAO = DateTime.Now, ID_ARGUMENTACAO = argumentacao2, ID_AVALIACAO_ARGUMENTACAO = avaliacaoargumentacao2 },
            //new Data.AVALIACAO_ARGUMENTACAO { Avaliacao = 34, IsUtil = true, MATRICULA_RESPONSAVEL = 25183, DT_MODIFICACAO = DateTime.Now, ID_ARGUMENTACAO = argumentacao2, ID_AVALIACAO_ARGUMENTACAO = new Guid() },
            //new Data.AVALIACAO_ARGUMENTACAO { Avaliacao = 95, IsUtil = false, MATRICULA_RESPONSAVEL = 25183, DT_MODIFICACAO = DateTime.Now, ID_ARGUMENTACAO = argumentacao2, ID_AVALIACAO_ARGUMENTACAO = new Guid() },
            //new Data.AVALIACAO_ARGUMENTACAO { Avaliacao = 43, IsUtil = true, MATRICULA_RESPONSAVEL = 25183, DT_MODIFICACAO = DateTime.Now, ID_ARGUMENTACAO = argumentacao3, ID_AVALIACAO_ARGUMENTACAO = new Guid() },
            new Data.AVALIACAO_ARGUMENTACAO { Avaliacao = 19, IsUtil = false, MATRICULA_RESPONSAVEL = 25183, DT_MODIFICACAO = DateTime.Now, ID_ARGUMENTACAO = argumentacao3, ID_AVALIACAO_ARGUMENTACAO = avaliacaoargumentacao3 }
        );

        modelBuilder.Entity<FICHA_TECNICA>().HasData(
            new FICHA_TECNICA
            {
                ID_FICHA = Guid.NewGuid(),
                ID_PRODUTO = produtoId,
                Especificação = "Tela",
                Valor = "6.5 polegadas",
                Categoria_Especificação = Categoria_Especificação.TELA,
                IsImportant = true,
                IsInfoAdicional = false
            },
            new FICHA_TECNICA
            {
                ID_FICHA = Guid.NewGuid(),
                ID_PRODUTO = produtoId,
                Especificação = "Tv",
                Valor = "false",
                Categoria_Especificação = Categoria_Especificação.FUNÇÕES,
                IsImportant = true,
                IsInfoAdicional = false
            },
            new FICHA_TECNICA
            {
                ID_FICHA = Guid.NewGuid(),
                ID_PRODUTO = produtoId,
                Especificação = "Mic. de Redução de Ruído",
                Valor = "true",
                Categoria_Especificação = Categoria_Especificação.SENSORES,
                IsImportant = true,
                IsInfoAdicional = false
            },
            new FICHA_TECNICA
            {
                ID_FICHA = Guid.NewGuid(),
                ID_PRODUTO = produtoId,
                Especificação = "Wi-Fi",
                Valor = "802.11 a/b/g/n/ac/6/6E/7",
                Categoria_Especificação = Categoria_Especificação.CONECTIVIDADE,
                IsImportant = true,
                IsInfoAdicional = false
            },
            new FICHA_TECNICA
            {
                ID_FICHA = Guid.NewGuid(),
                ID_PRODUTO = produtoId,
                Especificação = "NFC",
                Valor = "true",
                Categoria_Especificação = Categoria_Especificação.CONECTIVIDADE,
                IsImportant = true,
                IsInfoAdicional = false
            },
            new FICHA_TECNICA
            {
                ID_FICHA = Guid.NewGuid(),
                ID_PRODUTO = produtoId,
                Especificação = "Memória",
                Categoria_Especificação = Categoria_Especificação.GENÉRICO,
                Valor = "128GB",
                IsImportant = true,
                IsInfoAdicional = false
            }
        );

        string folderPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "FilesTemplates/CardapioDigital");
        List<PRODUTO_IMAGEM> imagens = [];
        for (int i = 1; i < 6; i++)
        {
            imagens.Add(new PRODUTO_IMAGEM
            {
                ID_IMAGEM = Guid.NewGuid(),
                ID_PRODUTO = produtoId,
                Imagem = SharedConverter.CompressFile(File.ReadAllBytes(Path.Combine(folderPath, $"A54{i}.jpg")))
            });
        }

        modelBuilder.Entity<PRODUTO_IMAGEM>().HasData(imagens);


        modelBuilder.Entity<PRODUTOS_CARDAPIO>(entity =>
        {
            entity.Property(e => e.ID_PRODUTO)
                .HasValueGenerator<SequentialGuidValueGenerator>();

            entity.HasMany(x => x.Ficha)
            .WithOne(x => x.Produto)
            .HasForeignKey(x => x.ID_PRODUTO)
            .IsRequired().OnDelete(DeleteBehavior.Cascade);

            entity.HasMany(x => x.Imagens)
                .WithOne(x => x.Produto)
                .HasForeignKey(x => x.ID_PRODUTO)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);

            entity.HasMany(x => x.Argumentacao)
                .WithOne(x => x.Produto)
                .HasForeignKey(x => x.ID_PRODUTO)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(x => x.Responsavel_Inclusao)
                .WithOne()
                .HasForeignKey<PRODUTOS_CARDAPIO>("MAT_INCLUSÃO")
                .HasPrincipalKey<ACESSOS_MOBILE>("MATRICULA")
                .IsRequired(false);

            entity.HasOne(x => x.Responsavel_Modificacao)
                .WithOne()
                .HasForeignKey<PRODUTOS_CARDAPIO>("MAT_MODIFICAÇÃO")
                .HasPrincipalKey<ACESSOS_MOBILE>("MATRICULA")
                .IsRequired(false);
        });

        modelBuilder.Entity<ARGUMENTACAO_OURO>(entity =>
        {
            entity.HasMany(x => x.Avaliacoes)
               .WithOne(x => x.Argumentacao)
               .HasForeignKey(x => x.ID_ARGUMENTACAO)
               .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(x => x.Responsavel)
              .WithOne()
              .HasForeignKey<ARGUMENTACAO_OURO>(x => x.MATRICULA_RESPONSAVEL)
              .HasPrincipalKey<ACESSOS_MOBILE>("MATRICULA")
              .IsRequired();
        });

        modelBuilder.Entity<AVALIACAO_ARGUMENTACAO>(entity =>
        {
            entity.HasOne(x => x.Argumentacao)
                .WithMany(x => x.Avaliacoes)
                .HasForeignKey(x => x.ID_ARGUMENTACAO)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(x => x.Responsavel)
                .WithOne()
                .HasForeignKey<AVALIACAO_ARGUMENTACAO>(x => x.MATRICULA_RESPONSAVEL)
                .HasPrincipalKey<ACESSOS_MOBILE>("MATRICULA")
                .IsRequired();
        });

        modelBuilder.Entity<PRODUTO_AVALIACAO>(entity =>
        {
            entity.HasOne(x => x.Produto)
            .WithOne(x => x.Avaliacao)
            .HasPrincipalKey<PRODUTOS_CARDAPIO>(x => x.ID_PRODUTO)
            .HasForeignKey<PRODUTO_AVALIACAO>(x => x.ID_PRODUTO)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
        });

        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}