﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace Shared_Static_Class.Converters
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue, bool AddPreString = false, string? PreString = null)
        {
            FieldInfo fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            DisplayAttribute displayAttribute = fieldInfo.GetCustomAttribute<DisplayAttribute>();

            if (displayAttribute != null)
            {
                return displayAttribute.Name;
            }
            if (AddPreString)
                return PreString + enumValue.ToString();
            else
                return enumValue.ToString();
        }
    }

    public enum Prioridade
    {
        [Display(Name = "Baixa")]
        LEVE = 0,
        [Display(Name = "Médio")]
        MEDIO = 1,
        [Display(Name = "Alto")]
        ALTA = 2
    }

    public enum RespostaAcessoPendente
    {
        FINALIZADO = 1,
        REPROVADO = 2,
        DEVOLVIDO_PARA_SOLICITANTE = 3,
        AGUARDANDO_ANALISTA = 4,
        FINALIZADO_ALTERAÇÃO = 5,
    }

    public enum Canal
    {
        [Display(Name = "Administrador")]
        ADM = 0,
        [Display(Name = "Venda Externa")]
        Venda_Externa = 1,
        [Display(Name = "Consumer")]
        Consumer = 2,
        [Display(Name = "Lojas Próprias")]
        Lojas_Próprias = 3,
        [Display(Name = "Revenda")]
        Revenda = 4,
        [Display(Name = "Canal Vendas")]
        Canal_Vendas = 5,
    }
    public enum Cargos
    {
        [Display(Name = "Administrador")]
        ADM = 0,
        [Display(Name = "Vendedor PAP")]
        Vendedor_PAP = 1,
        [Display(Name = "Gerente Parceiros")]
        Gerente_Parceiros = 2,
        [Display(Name = "Gerente Geral")]
        Gerente_Geral = 3,
        [Display(Name = "Supervisor PAP")]
        Supervisor_PAP = 4,
        [Display(Name = "Vendedor de Revenda")]
        Vendedor_Revenda = 5,
        [Display(Name = "Gerente de Revenda")]
        Gerente_Revenda = 6,
        [Display(Name = "Gerente de Área")]
        Gerente_Área = 7,
        [Display(Name = "Gerente de Operações")]
        Gerente_Operações = 8,
        [Display(Name = "Consultor de Negócios")]
        Consultor_Negócios = 9,
        [Display(Name = "Consultor Tecnológico")]
        Consultor_Tecnológico = 10,
        [Display(Name = "Gerente Vendas B2B")]
        Gerente_Vendas_B2C = 11,
        [Display(Name = "Gerente Senior Territorial")]
        Gerente_Senior_Territorial = 12,
        [Display(Name = "Coordenador Suporte Vendas")]
        Coordenador_Suporte_Vendas = 13,
        [Display(Name = "Gerente Suporte Vendas")]
        Gerente_Suporte_Vendas = 14,
        [Display(Name = "Diretora")]
        Diretora = 15,
        [Display(Name = "Consultor Gestão Vendas")]
        Consultor_Gestão_Vendas = 16,
        [Display(Name = "Analista Suporte Vendas Senior")]
        Analista_Suporte_Vendas_Senior = 17,
        [Display(Name = "Analista Suporte Vendas Pleno")]
        Analista_Suporte_Vendas_Pleno = 18,
        [Display(Name = "Analista Suporte Vendas Junior")]
        Analista_Suporte_Vendas_Junior = 19,
        [Display(Name = "Estagiário")]
        Estagiário = 20,
        [Display(Name = "Gerente Senior Gestão Vendas")]
        Gerente_Senior_Gestão_Vendas = 21,
        [Display(Name = "Analista de Suporte Comercial")]
        Analista_de_Suporte_Comercial = 22,
    }

    public enum Acao
    {
        [Display(Name = "Selecione")] NULL = 0,
        [Display(Name = "1 - Inclusão")] INCLUSÃO = 1,
        [Display(Name = "2 - Alteração")] ALTERAÇÃO = 2,
        [Display(Name = "3 - Reativação")] REATIVAÇÃO = 3
    }

    public enum Genero
    {
        [Display(Name = "Selecione")] NULL = 0,
        [Display(Name = "MASCULINO")] M = 1,
        [Display(Name = "FEMININO")] F = 2,
        [Display(Name = "OUTRO")] OUTRO = 3
    }

    public enum Canal_Acesso_Terceiro
    {
        [Display(Name = "Selecione")] NULL = 0,
        [Display(Name = "VAREJO")] VAREJO = 1,
        [Display(Name = "REVENDA")] REVENDA = 2,
        [Display(Name = "DISTRIBUIÇÃO")] DISTRIBUIÇÃO = 3,
    }

    public enum Operadora
    {
        [Display(Name = "Selecione")] NULL = 0,
        [Display(Name = "VIVO")] VIVO = 1,
        [Display(Name = "OI")] OI = 2,
        [Display(Name = "CLARO")] CLARO = 3,
        [Display(Name = "TIM")] TIM = 4,
    }

    public enum Funcao
    {
        [Display(Name = "Selecione")] NULL = 0,
        [Display(Name = "80000002 ANALISTA")] ANALISTA = 1,
        [Display(Name = "80000004 BACKOFFICE")] BACKOFFICE = 2,
        [Display(Name = "80000176 DIRETOR")] DIRETOR = 3,
        [Display(Name = "80000179 GERENTE")] GERENTE = 4,
        [Display(Name = "80000025 SUPERVISOR")] SUPERVISOR = 5,
        [Display(Name = "80000027 VENDEDOR")] VENDEDOR = 6,
    }

    public enum Estado
    {
        [Display(Name = "Selecione")] NULL = 0,
        [Display(Name = "AL")] AL = 1,
        [Display(Name = "AM")] AM = 2,
        [Display(Name = "AP")] AP = 3,
        [Display(Name = "BA")] BA = 4,
        [Display(Name = "CE")] CE = 5,
        [Display(Name = "DF")] DF = 6,
        [Display(Name = "ES")] ES = 7,
        [Display(Name = "GO")] GO = 8,
        [Display(Name = "MA")] MA = 9,
        [Display(Name = "MG")] MG = 10,
        [Display(Name = "MS")] MS = 11,
        [Display(Name = "MT")] MT = 12,
        [Display(Name = "PA")] PA = 13,
        [Display(Name = "PB")] PB = 14,
        [Display(Name = "PE")] PE = 15,
        [Display(Name = "PI")] PI = 16,
        [Display(Name = "PR")] PR = 17,
        [Display(Name = "RJ")] RJ = 18,
        [Display(Name = "RN")] RN = 19,
        [Display(Name = "RO")] RO = 20,
        [Display(Name = "RR")] RR = 21,
        [Display(Name = "RS")] RS = 22,
        [Display(Name = "SC")] SC = 23,
        [Display(Name = "SE")] SE = 24,
        [Display(Name = "SP")] SP = 25,
        [Display(Name = "TO")] TO = 26,

    }
}