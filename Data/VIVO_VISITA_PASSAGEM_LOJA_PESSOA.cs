﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("VIVO_VISITA_PASSAGEM_LOJA_PESSOAS")]
public partial class VIVO_VISITA_PASSAGEM_LOJA_PESSOA
{
    [Key]
    public int Id { get; set; }

    public int IdAbertura { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string PessoasSolicitadoSPPVagasAbertoSimNao { get; set; }

    [Unicode(false)]
    public string PessoasSolicitadoSPPVagasAbertoObs { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PessoasSolicitadoSPPVagasAbertoPrazo { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string PessoasSolicitadoSPPVagasAbertoResponsavel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string PessoasNaoExisteColaboradoresPendenciaTreinamentoSimNao { get; set; }

    [Unicode(false)]
    public string PessoasNaoExisteColaboradoresPendenciaTreinamentoObs { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PessoasNaoExisteColaboradoresPendenciaTreinamentoPrazo { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string PessoasNaoExisteColaboradoresPendenciaTreinamentoResponsavel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string PessoasLojaPossuiArquivoFolhaPontoTodasAssinadasSimNao { get; set; }

    [Unicode(false)]
    public string PessoasLojaPossuiArquivoFolhaPontoTodasAssinadasObs { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PessoasLojaPossuiArquivoFolhaPontoTodasAssinadasPrazo { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string PessoasLojaPossuiArquivoFolhaPontoTodasAssinadasResponsavel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string PessoasLojaPossuiProgramacaoFeriasSimNao { get; set; }

    [Unicode(false)]
    public string PessoasLojaPossuiProgramacaoFeriasObs { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PessoasLojaPossuiProgramacaoFeriasPrazo { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string PessoasLojaPossuiProgramacaoFeriasResponsavel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string PessoasTodosColaboradoresPossuemCrachaSimNao { get; set; }

    [Unicode(false)]
    public string PessoasTodosColaboradoresPossuemCrachaObs { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PessoasTodosColaboradoresPossuemCrachaPrazo { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string PessoasTodosColaboradoresPossuemCrachaResponsavel { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCadastro { get; set; }
}