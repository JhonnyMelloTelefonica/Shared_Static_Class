﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared_Static_Class.Data;

[Table("ACESSO_TERCEIROS")]
public partial class ACESSO_TERCEIRO
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Acao { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string TipoAcesso { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Adabas { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    public string Nome { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    public string Sobrenome { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Sexo { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Cpf { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Rg { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string OrgaoEmissor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataNascimento { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Rua { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Numero { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Complemento { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Cidade { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Bairro { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Cep { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Estado { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Telefone { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Celular { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Cnpj { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    public string NomeContato { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string SubGrupo { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string DataContratoInicio { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string DataContratoFim { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Area { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string SubArea { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Ddd { get; set; }

    public int IdAcesso { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataCadastro { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataFinalizacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataExtracao { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Login { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Senha { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Obs { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Perfil { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Matricula { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Funcao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MobileToken { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RejeitarSenha { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string AceiteSenha { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataStatus { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string NomeMae { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataMatricula { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Origem { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string PIS { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string EstadoPrestServico { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string CidadePrestServico { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string EMAILPESSOAL { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string GESTORLIDER { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string TELEFONEPESSOAL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Regional { get; set; }
}