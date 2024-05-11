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
using Shared_Static_Class.Enums;

namespace Shared_Static_Class.Data;

[Table("DEMANDA_ACESSOS", Schema = "Demandas")]
[AddINotifyPropertyChangedInterface]
public partial class DEMANDA_ACESSOS : INotifyPropertyChanged
{
    [Key]
    public int ID { get; set; }
    [Unicode(false)]
    public Guid ID_RELACAO { get; set; }
    [Unicode(false)]
    public int MATRICULA_SOLICITANTE { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    [EnumDataType(typeof(Acao), ErrorMessage = "Por favor escolha um valor válido")]
    public Acao? Acao { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string TipoAcesso { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Adabas { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Sobrenome { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    [EnumDataType(typeof(Genero), ErrorMessage = "Por favor escolha um valor válido")]
    public Genero? Sexo { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Cpf
    {
        get => _cpf; 
        set
        {
            _cpf = FormatInputs.FormatCPF(value);
        }
    }
    private string _cpf;

    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Rg { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string OrgaoEmissor { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    [DataType(DataType.Date, ErrorMessage = "Campo {0} não é uma data válida")]
    public DateTime? DataNascimento { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Rua { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Numero { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Complemento { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Cidade { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Bairro { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Cep { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    [EnumDataType(typeof(Estado), ErrorMessage = "Por favor escolha um valor válido")]
    public Estado? Estado { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    [EmailAddress(ErrorMessage = "Formato inválido")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    [Phone(ErrorMessage = "Formato inválido")]
    public string Telefone
    {
        get => _telefone;
        set
        {
            _telefone = FormatInputs.FormatTelefone(value);
        }
    }
    private string _telefone;

    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    [Phone]
    public string Celular { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Cnpj { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string NomeContato { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string SubGrupo { get; set; }
    public DateTime? DataContratoInicio { get; set; }
    public DateTime? DataContratoFim => DataContratoInicio?.AddDays(2);

    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    [EnumDataType(typeof(Estado), ErrorMessage = "Por favor escolha um valor válido")]
    public Estado? Area { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string SubArea { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Ddd { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    [DataType(DataType.Date, ErrorMessage = "Campo {0} não é uma data válida")]
    public DateTime? DataCadastro { get; set; }
    public DateTime? DataFinalizacao { get; set; }
    public DateTime? DataExtracao { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Login { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Senha { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Obs { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Perfil { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Matricula { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    [EnumDataType(typeof(Funcao), ErrorMessage = "Por favor escolha um valor válido")]
    public Funcao? Funcao { get; set; }
    public DateTime? RejeitarSenha { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string AceiteSenha { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Status { get; set; }
    public DateTime? DataStatus { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string NomeMae { get; set; }
    public DateTime? DataMatricula { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Origem { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string PIS { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Regional { get; set; }

    [ForeignKey("ID_RELACAO")]
    [JsonIgnore]
    [AllowNull]
    public virtual DEMANDA_RELACAO_CHAMADO Relacao { get; set; } = new();

    [ForeignKey("MATRICULA_SOLICITANTE")]
    [JsonIgnore]
    [AllowNull]
    public virtual ACESSOS_MOBILE? Solicitante { get; set; }
}