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
using Shared_Static_Class.Model_ForumRTCZ_Context;

namespace Shared_Static_Class.DB_Context_Vivo_MAIS;

public partial class ForumRTCZContext : DbContext
{
    public ForumRTCZContext()
    {
    }

    public ForumRTCZContext(DbContextOptions<ForumRTCZContext> options)
        : base(options)
    {

    }

    public virtual DbSet<ACESSOS_MOBILE> ACESSOS_MOBILE { get; set; }
    public virtual DbSet<PERFIL_USUARIO> PERFIL_USUARIO { get; set; }
    public virtual DbSet<PUBLICACAO_SOLICITACAO> PUBLICACAO_SOLICITACAO { get; set; }
    public virtual DbSet<AVALIACAO_PUBLICACAO> AVALIACAO_PUBLICACAO { get; set; }
    public virtual DbSet<RESPONSAVEL_TEMA> RESPONSAVEL_TEMA { get; set; }
    public virtual DbSet<RESPOSTA_PUBLICACAO> RESPOSTA_PUBLICACAO { get; set; }
    public virtual DbSet<JORNADA_BD_TEMAS_SUB_TEMA> JORNADA_BD_TEMAS_SUB_TEMA { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        optionsBuilder.UseSqlServer("Data Source=10.124.100.153;Initial Catalog=Vivo_MAIS;TrustServerCertificate=True;User ID=RegionalNE;Password=RegionalNEvivo2019;MultipleActiveResultSets=true"
            , o =>
            {
                o.UseCompatibilityLevel(120);
                o.CommandTimeout(36000);
                o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                o.MigrationsHistoryTable("__EFMigrationsHistory", "Fórum");
                o.MigrationsAssembly("Api Vivo Apps");
            });
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<ACESSOS_MOBILE>().ToTable("ACESSOS_MOBILE", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<PERFIL_USUARIO>().ToTable("PERFIL_USUARIO", t => t.ExcludeFromMigrations());
        modelBuilder.Entity<JORNADA_BD_TEMAS_SUB_TEMA>().ToTable("JORNADA_BD_TEMAS_SUB_TEMAS", t => t.ExcludeFromMigrations());

        int[] operadores = [64960, 16279, 25183, 94842, 25677, 156305, 152001, 80900909, 160624, 80796597, 80904800, 40416900, 156727, 159706, 30722, 40417113, 156114, 51336, 3511507, 71114, 69372, 3458749, 40418413, 47333, 163794, 80886919, 157239, 16005];
       int[] subtemas = [4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130];

        Random rnd = new Random();
        Guid publiguid1 = Guid.NewGuid();
        Guid publiguid2 = Guid.NewGuid();
        Guid publiguid3 = Guid.NewGuid();

        var publi1 = new PUBLICACAO_SOLICITACAO(publiguid1, "Apenas um teste de publicação no fórum do Giro V", subtemas[rnd.Next(0,126)], 80904800, DateTime.Now);
        var publi2 = new PUBLICACAO_SOLICITACAO(publiguid2, "Apenas mais um teste de publicação no fórum do Giro V", subtemas[rnd.Next(0, 126)], 156114, DateTime.Now);
        var publi3 = new PUBLICACAO_SOLICITACAO(publiguid3, "Apenas outro teste de publicação no fórum do Giro V", subtemas[rnd.Next(0, 126)], 3511507, DateTime.Now);

        modelBuilder.Entity<PUBLICACAO_SOLICITACAO>(entity =>
        {
            entity.HasData([publi1, publi2, publi3]);

            entity.Property(e => e.ID_SOLICITACAO_PUBLICACAO)
                .HasValueGenerator<SequentialGuidValueGenerator>();

            entity.HasMany(x => x.Avaliacao)
            .WithOne(x => x.Publicacao_Principal)
            .HasPrincipalKey(x => x.ID_SOLICITACAO_PUBLICACAO)
            .HasForeignKey(x => x.ID_AVALIACAO)
            .IsRequired().OnDelete(DeleteBehavior.Cascade);

            entity.HasMany(x => x.Respostas)
                .WithOne(x => x.Publicacao_alvo)
                .HasPrincipalKey(x => x.ID_SOLICITACAO_PUBLICACAO)
                .HasForeignKey(x => x.ID_PUBLICACAO)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(x => x.Tema)
                .WithMany()
                .HasPrincipalKey("ID_SUB_TEMAS")
                .HasForeignKey(x => x.SUB_TEMA)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(x => x.Responsavel)
                .WithMany()
                .HasPrincipalKey("MATRICULA")
                .HasForeignKey(x => x.MAT_RESPONSAVEL)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<AVALIACAO_PUBLICACAO>(entity =>
        {
            entity.HasOne(x => x.Resposta_Publicacao)
                .WithMany(x => x.Avaliacao)
                .HasPrincipalKey(x => x.ID_PUBLICACAO)
                .HasForeignKey(x => x.ID_PUBLICACAO)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasOne(x => x.Publicacao_Principal)
                .WithMany(x => x.Avaliacao)
                .HasPrincipalKey(x => x.ID_SOLICITACAO_PUBLICACAO)
                .HasForeignKey(x => x.ID_PUBLICACAO)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasOne(x => x.Responsavel)
                .WithMany()
                .HasPrincipalKey("MATRICULA")
                .HasForeignKey(x => x.MATRICULA_RESPONSAVEL)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<RESPONSAVEL_TEMA>(entity =>
        {

            RESPONSAVEL_TEMA[] responsaveis = [];

            for (int i = 1; i < 130; i++)
            {
                responsaveis = responsaveis.Append(new RESPONSAVEL_TEMA(Guid.NewGuid(), operadores[rnd.Next(0, 27)], subtemas[rnd.Next(0, 126)], DateTime.Now)).ToArray();
            }

            entity.HasData(responsaveis);

            entity.HasOne(x => x.Tema)
                .WithMany()
                .HasPrincipalKey("ID_SUB_TEMAS")
                .HasForeignKey(x => x.SUB_TEMA)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(x => x.Responsavel)
                .WithMany()
                .HasPrincipalKey("MATRICULA")
                .HasForeignKey(x => x.MATRICULA_RESPONSAVEL)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);
        });


        var resposta1 = new RESPOSTA_PUBLICACAO(Guid.NewGuid(), publiguid1, DateTime.Now, operadores[rnd.Next(0, 27)], "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉");
        var resposta2 = new RESPOSTA_PUBLICACAO(Guid.NewGuid(), publiguid1, DateTime.Now, operadores[rnd.Next(0, 27)], "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉");
        var resposta3 = new RESPOSTA_PUBLICACAO(Guid.NewGuid(), publiguid1, DateTime.Now, operadores[rnd.Next(0, 27)], "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉");
        var resposta4 = new RESPOSTA_PUBLICACAO(Guid.NewGuid(), publiguid2, DateTime.Now, operadores[rnd.Next(0, 27)], "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉");
        var resposta5 = new RESPOSTA_PUBLICACAO(Guid.NewGuid(), publiguid2, DateTime.Now, operadores[rnd.Next(0, 27)], "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉");
        var resposta6 = new RESPOSTA_PUBLICACAO(Guid.NewGuid(), publiguid2, DateTime.Now, operadores[rnd.Next(0, 27)], "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉");
        var resposta7 = new RESPOSTA_PUBLICACAO(Guid.NewGuid(), publiguid3, DateTime.Now, operadores[rnd.Next(0, 27)], "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉");
        var resposta8 = new RESPOSTA_PUBLICACAO(Guid.NewGuid(), publiguid3, DateTime.Now, operadores[rnd.Next(0, 27)], "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉");
        var resposta9 = new RESPOSTA_PUBLICACAO(Guid.NewGuid(), publiguid3, DateTime.Now, operadores[rnd.Next(0, 27)], "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉");


        modelBuilder.Entity<RESPOSTA_PUBLICACAO>(entity =>
        {
            entity.HasData([resposta1,resposta2,resposta3,resposta4,resposta5,resposta6,resposta7,resposta8,resposta9]);

            entity.HasOne(x => x.Publicacao_alvo)
                .WithMany(x=> x.Respostas)
                .HasPrincipalKey(x=> x.ID_SOLICITACAO_PUBLICACAO)
                .HasForeignKey(x => x.ID_SOLICITACAO_PUBLICACAO)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(x => x.Solicitante)
                .WithMany()
                .HasPrincipalKey("MATRICULA")
                .HasForeignKey(x => x.MAT_SOLICITANTE)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);
        });

        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}