﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("VIVO_VISITA_PASSAGEM_LOJA_VAGAS")]
public partial class VIVO_VISITA_PASSAGEM_LOJA_VAGA
{
    [Key]
    public int Id { get; set; }

    public int IdAbertura { get; set; }

    public int? VagasQuantidadeVagasGerenteGeral { get; set; }

    public int? VagasQuantidadeVagasGerenteNegocios { get; set; }

    public int? VagasQuantidadeVagasConsultorRelacionamento { get; set; }

    public int? VagasQuantidadeVagasConsultorPremium { get; set; }

    public int? VagasQuantidadeVagasConsultorNegocios { get; set; }

    public int? VagasQuantidadeVagasAnalistaSuporteComercial { get; set; }

    public int? VagasQuantidadeVagasCaixa { get; set; }

    public int? VagasQuantidadeVagasRecepcionista { get; set; }

    public int? VagasAtivosGerenteGeral { get; set; }

    public int? VagasAtivosGerenteNegocios { get; set; }

    public int? VagasAtivosConsultorRelacionamento { get; set; }

    public int? VagasAtivosConsultorPremium { get; set; }

    public int? VagasAtivosConsultorNegocios { get; set; }

    public int? VagasAtivosAnalistaSuporteComercial { get; set; }

    public int? VagasAtivosCaixa { get; set; }

    public int? VagasAtivosRecepcionista { get; set; }

    public int? VagasVagasAbertoGerenteGeral { get; set; }

    public int? VagasVagasAbertoGerenteNegocios { get; set; }

    public int? VagasVagasAbertoConsultorRelacionamento { get; set; }

    public int? VagasVagasAbertoConsultorPremium { get; set; }

    public int? VagasVagasAbertoConsultorNegocios { get; set; }

    public int? VagasVagasAbertoAnalistaSuporteComercial { get; set; }

    public int? VagasVagasAbertoCaixa { get; set; }

    public int? VagasVagasAbertoRecepcionista { get; set; }

    public int? VagasLicencaAfastadosGerenteGeral { get; set; }

    public int? VagasLicencaAfastadosGerenteNegocios { get; set; }

    public int? VagasLicencaAfastadosConsultorRelacionamento { get; set; }

    public int? VagasLicencaAfastadosConsultorPremium { get; set; }

    public int? VagasLicencaAfastadosConsultorNegocios { get; set; }

    public int? VagasLicencaAfastadosAnalistaSuporteComercial { get; set; }

    public int? VagasLicencaAfastadosCaixa { get; set; }

    public int? VagasLicencaAfastadosRecepcionista { get; set; }

    public int? VagasQuadroTotalGerenteGeral { get; set; }

    public int? VagasQuadroTotalGerenteNegocios { get; set; }

    public int? VagasQuadroTotalConsultorRelacionamento { get; set; }

    public int? VagasQuadroTotalConsultorPremium { get; set; }

    public int? VagasQuadroTotalConsultorNegocios { get; set; }

    public int? VagasQuadroTotalAnalistaSuporteComercial { get; set; }

    public int? VagasQuadroTotalCaixa { get; set; }

    public int? VagasQuadroTotalRecepcionista { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCadastro { get; set; }
}