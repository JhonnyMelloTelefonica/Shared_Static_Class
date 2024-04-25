﻿using FluentValidation;
using FluentValidation.Internal;
using FluentValidation.Results;
using FluentValidation.Validators;
using Shared_Static_Class.Data;
using Shared_Static_Class.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace Shared_Static_Class.Models
{
    {
        }
        private string _email = string.Empty;
        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(0,99999999,ErrorMessage = "Campo obrigatório")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Valor de matrícula inválido")]
        public int MATRICULA
        {
            get => _matricula;
            set => SetField(ref _matricula, value);
        }
        private int _matricula;

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(14, ErrorMessage = "Número máximo de caracteres excedido, máximo : {1} ")]
        [MinLength(6, ErrorMessage = "Número minímo de caracteres não foi atingido, minímo : {1}")]
        public string SENHA
        {
            get => _senha;
            set => SetField(ref _senha, value);
        }
        private string _senha = string.Empty;

        [Required(ErrorMessage = "Campo obrigatório")]
        [Compare(nameof(SENHA), ErrorMessage = "Campos precisam ser iguais")]
        public string CONFIRMSENHA
        {
            get => _confirmsenha;
            set => SetField(ref _confirmsenha, value);
        }
        private string _confirmsenha = string.Empty;

        [Required(ErrorMessage = "Campo obrigatório")]
        public string REGIONAL
        {
            get => _regional;
            set => SetField(ref _regional, value);
        }
        private string _regional = string.Empty;
        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Campo obrigatório")]
        public int CARGO
        {
            get => _cargo;
            set => SetField(ref _cargo, value);
        }
        private int _cargo;
        public int? CANAL
        {
            get => _canal;
            set => SetField(ref _canal, value);
        }
        private int? _canal;

        [Required(ErrorMessage = "Campo obrigatório")]
        public string PDV
        {
            get => _pdv;
            set => SetField(ref _pdv, value);
        }
        private string _pdv = string.Empty;

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(14, ErrorMessage ="Preenchimento inválido")]
        [MinLength(14, ErrorMessage = "Preenchimento inválido")]
        public string CPF
        {
            get => _cpf;
            set => SetField(ref _cpf, value);
        }
        private string _cpf = string.Empty;
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50, ErrorMessage = "Número máximo de caractere: {1}")]
        public string NOME
        {
            get => _nome;
            set => SetField(ref _nome, value);
        }
        private string _nome = string.Empty;

        [Required(ErrorMessage = "Campo obrigatório")]
        public string UF
        {
            get => _uf;
            set => SetField(ref _uf, value);
        }
        private string _uf = string.Empty;

        public bool? STATUS
        {
            get => _status;
            set => SetField(ref _status, value);
        }
        private bool? _status;
        [Required(ErrorMessage = "Campo obrigatório")]
        public bool? FIXA
        {
            get => _fixa;
            set => SetField(ref _fixa, value);
        }
        private bool? _fixa;

        public string? TP_AFASTAMENTO
        {
            get => _tpAfastamento;
            set => SetField(ref _tpAfastamento, value);
        }
        private string? _tpAfastamento;

        public string? OBS
        {
            get => _obs;
            set => SetField(ref _obs, value);
        }
        private string? _obs = string.Empty;

        public byte[]? UserAvatar
        {
            get => _userAvatar;
            set => SetField(ref _userAvatar, value);
        }
        private byte[]? _userAvatar;

        public int? LOGIN_MOD
        {
            get => _loginMod;
            set => SetField(ref _loginMod, value);
        }
        private int? _loginMod;

        public DateTime? DT_MOD
        {
            get => _dtMod;
            set => SetField(ref _dtMod, value);
        }
        private DateTime? _dtMod;

        public bool ELEGIVEL
        {
            get => _elegivel;
            set => SetField(ref _elegivel, value);
        }
        private bool _elegivel;
        [Range(1, 99, ErrorMessage = "Valor inválido")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int DDD
        {
            get => _ddd;
            set => SetField(ref _ddd, value);
        }
        private int _ddd;

        public string TP_STATUS
        {
            get => _tpStatus;
            set => SetField(ref _tpStatus, value);
        }
        private string _tpStatus = string.Empty;

        [Required(ErrorMessage = "Campo obrigatório")]
        [ListHasElements(ErrorMessage = "Campo {0} precisa conter algum elemento")]
        public List<int> Perfil
        {
            get => _perfil;
            set => SetField(ref _perfil, value);
        }
        private List<int> _perfil = [];
    }

    public class ListHasElements : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
                return false;

            if (value is IEnumerable enumerable) 
                return enumerable.Cast<int>().Where(x=> x != 0).Any();
            else return false;
        }
    }

    public static class FluentValidationExtensions
    {
        public static IDictionary<string, string[]> ToDictionary(this ValidationResult validationResult)
        {
            return validationResult.Errors
              .GroupBy(x => x.PropertyName)
              .ToDictionary(
                g => g.Key,
                g => g.Select(x => x.ErrorMessage).ToArray()
              );
        }
    }

}
