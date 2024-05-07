﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Shared_Static_Class.Converters;
using Shared_Static_Class.Data;

namespace Shared_Static_Class.DB_Context_Vivo_MAIS;

public partial class DemandasContext : DbContext
{
    public DemandasContext()
    {
    }

    public DemandasContext(DbContextOptions<DemandasContext> options)
        : base(options)
    {
    }
    public virtual DbSet<DEMANDA_RELACAO_CHAMADO> DEMANDA_RELACAO_CHAMADO { get; set; }
    public virtual DbSet<DEMANDA_ACESSOS> DEMANDA_ACESSOS { get; set; }
    public virtual DbSet<DEMANDA_DESLIGAMENTOS> DEMANDA_DESLIGAMENTOS { get; set; }
    public virtual DbSet<DEMANDA_CHAMADO> DEMANDA_CHAMADO { get; set; }
    public virtual DbSet<DEMANDA_CHAMADO_RESPOSTA> DEMANDA_CHAMADO_RESPOSTA { get; set; }
    public virtual DbSet<DEMANDA_ARQUIVOS_RESPOSTA> DEMANDA_ARQUIVOS_RESPOSTA { get; set; }
    public virtual DbSet<DEMANDA_CAMPOS_CHAMADO> DEMANDA_CAMPOS_CHAMADO { get; set; }
    public virtual DbSet<DEMANDA_STATUS_CHAMADO> DEMANDA_STATUS_CHAMADO { get; set; }
    public virtual DbSet<DEMANDA_HISTORICO_PRIORIDADE> DEMANDA_HISTORICO_PRIORIDADE { get; set; }
    public virtual DbSet<ACESSOS_MOBILE> ACESSOS_MOBILE { get; set; }
    public virtual DbSet<DEMANDA_SUB_FILA> DEMANDA_SUB_FILA { get; set; }
    public virtual DbSet<DEMANDA_TIPO_FILA> DEMANDA_TIPO_FILA { get; set; }
    public virtual DbSet<DEMANDA_CAMPOS_FILA> DEMANDA_CAMPOS_FILA { get; set; }
    public virtual DbSet<DEMANDA_VALORES_CAMPOS_SUSPENSO> DEMANDA_VALORES_CAMPOS_SUSPENSO { get; set; }
    public virtual DbSet<DEMANDA_RESPONSAVEL_FILA> DEMANDA_RESPONSAVEL_FILA { get; set; }
    public virtual DbSet<DEMANDA_PARQUE> DEMANDA_PARQUE { get; set; }
    public virtual DbSet<DEMANDA_AVALIACAO_ANALISTA> DEMANDA_AVALIACAO_ANALISTA { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
=> optionsBuilder.UseSqlServer("Data Source=10.124.100.153;Initial Catalog=Vivo_MAIS;TrustServerCertificate=True;User ID=RegionalNE;Password=RegionalNEvivo2019;MultipleActiveResultSets=true"
            , o => { o.UseCompatibilityLevel(120); o.CommandTimeout(36000); o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery); o.MigrationsHistoryTable("__EFMigrationsHistory", "Demandas"); });

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<ACESSOS_MOBILE>().ToTable("ACESSOS_MOBILE", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_SUB_FILA>().ToTable("DEMANDA_SUB_FILA", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_TIPO_FILA>().ToTable("DEMANDA_TIPO_FILA", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_CAMPOS_FILA>().ToTable("DEMANDA_CAMPOS_FILA", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_VALORES_CAMPOS_SUSPENSO>().ToTable("DEMANDA_VALORES_CAMPOS_SUSPENSO", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<DEMANDA_RESPONSAVEL_FILA>().ToTable("DEMANDA_RESPONSAVEL_FILA", t => t.ExcludeFromMigrations());

        modelBuilder.Entity<DEMANDA_CHAMADO>(entity =>
        {
            entity.HasOne(pt => pt.Solicitante)
            .WithMany(t => t.DemandasSolicitadas)
            .HasForeignKey(pt => pt.MATRICULA_SOLICITANTE)
            .HasPrincipalKey(pk => pk.MATRICULA);

            entity.HasOne(pt => pt.Responsavel)
            .WithMany(t => t.DemandasResponsavel)
            .HasForeignKey(pt => pt.MATRICULA_RESPONSAVEL)
            .HasPrincipalKey(pk => pk.MATRICULA);

            entity.HasOne(pt => pt.Has_Cliente_Valor)
                .WithMany(t => t.DEMANDA)
                .HasForeignKey(pt => pt.CLIENTE_ALTO_VALOR)
                .HasPrincipalKey(pk => pk.ID);
        });

        modelBuilder.Entity<DEMANDA_STATUS_CHAMADO>()
            .HasOne(a => a.Resposta)
            .WithOne(b => b.Status)
                .HasPrincipalKey<DEMANDA_CHAMADO_RESPOSTA>(b => b.ID)
            .IsRequired();

        modelBuilder.Entity<DEMANDA_CHAMADO_RESPOSTA>(entity =>
        {
            entity.HasOne(a => a.Status)
            .WithOne(b => b.Resposta)
                .HasForeignKey<DEMANDA_STATUS_CHAMADO>(b => b.ID_RESPOSTA);

            entity.HasOne(pt => pt.Responsavel)
                .WithMany(t => t.RespostasDemandas)
                .HasForeignKey(pt => pt.MATRICULA_RESPONSAVEL)
                .HasPrincipalKey(pk => pk.MATRICULA);
        });
        modelBuilder.Entity<DEMANDA_ACESSOS>(entity =>
        {
            entity.Property(e => e.Sexo)
                .HasConversion<string>();

            entity.Property(e => e.Acao)
                .HasConversion<string>();
        });

        modelBuilder.Entity<DEMANDA_RELACAO_CHAMADO>(entity =>
        {
            entity.Property(e => e.ID)
            .HasValueGenerator<SequentialGuidValueGenerator>();
        });

        modelBuilder.Entity<DEMANDA_ACESSOS>().Property(x => x.Sexo).HasDefaultValue(Genero.NULL);

        modelBuilder.Entity<DEMANDA_ACESSOS>().Property(x => x.Acao).HasDefaultValue(Acao.NULL);

        modelBuilder.Entity<DEMANDA_ACESSOS>().Property(x => x.Estado).HasDefaultValue(Estado.NULL);

        modelBuilder.Entity<DEMANDA_ACESSOS>().Property(x => x.Funcao).HasDefaultValue(Funcao.NULL);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}