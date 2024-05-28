﻿using Shared_Static_Class.Converters;
using Shared_Static_Class.Data;
using Shared_Static_Class.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared_Static_Class.Model_DTO
{
    public class DESLIGAMENTO_DTO
    {
        public int ID { get; set; }
        public Guid ID_RELACAO { get; set; }
        public DateTime DATA_ABERTURA { get; set; }
        public string REGIONAL { get; set; } = string.Empty;
        public int Matricula { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Cpf
        {
            get => _cpf;
            set
            {
                _cpf = FormatInputs.FormatCPF(value);
            }
        }
        private string _cpf = string.Empty;
        public ACESSOS_MOBILE Solicitante { get; set; } = new();
        public ACESSOS_MOBILE? Responsavel { get; set; } = null;
        public IEnumerable<DEMANDA_CHAMADO_RESPOSTA_DTO> Respostas { get; set; } = [];
    }

}
