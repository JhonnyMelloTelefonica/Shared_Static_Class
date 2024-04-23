﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Shared_Static_Class.Converters;
using Shared_Static_Class.Enums;

namespace Shared_Static_Class.Data;

[Table("DEMANDA_ACESSOS", Schema = "Demandas")]
public partial class DEMANDA_ACESSOS
{
    [Key]
    public int ID { get; set; }
    [Required]
    public Guid ID_RELACAO { get; set; }
    public int MATRICULA_SOLICITANTE { get; set; }
    public Acao Acao { get; set; }
    public string TipoAcesso { get; set; }
    public string Adabas { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public Genero Sexo { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public string OrgaoEmissor { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Rua { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set; }
    public string Cidade { get; set; }
    public string Bairro { get; set; }
    public string Cep { get; set; }
    public Estado Estado { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Celular { get; set; }
    public string Cnpj { get; set; }
    public string NomeContato { get; set; }
    public string SubGrupo { get; set; }
    public string DataContratoInicio { get; set; }
    public string DataContratoFim { get; set; }
    public Estado Area { get; set; }
    public string SubArea { get; set; }
    public string Ddd { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime? DataFinalizacao { get; set; }
    public DateTime? DataExtracao { get; set; }
    public string Login { get; set; }
    public string Senha { get; set; }
    public string Obs { get; set; }
    public string Perfil { get; set; }
    public string Matricula { get; set; }
    public Funcao Funcao { get; set; }
    public DateTime? MobileToken { get; set; }
    public DateTime? RejeitarSenha { get; set; }
    public string AceiteSenha { get; set; }
    public string Status { get; set; }
    public DateTime? DataStatus { get; set; }
    public string NomeMae { get; set; }
    public DateTime? DataMatricula { get; set; }
    public string Origem { get; set; }
    public string PIS { get; set; }
    public string Regional { get; set; }

    [ForeignKey("ID_RELACAO")]
    [Required]
    [JsonIgnore]
    public virtual DEMANDA_RELACAO_CHAMADO Relacao { get; set; }

    [ForeignKey("MATRICULA_SOLICITANTE")]
    public virtual ACESSOS_MOBILE Solicitante { get; set; }
}

    