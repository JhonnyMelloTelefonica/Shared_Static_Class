﻿using Shared_Static_Class.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared_Static_Class.Models
{
    public class CRIAR_DEMANDA_MODEL
    {
        public required int ID_TIPO_FILA { get; set; }
        public required int ID_FILA { get; set; }
        public List<CAMPOS_DEMANDA> CAMPOS { get; set; } = new();
        public string? Campo_Problema { get; set; }
        public byte[]? Arquivo_abertura { get; set; } = new byte[0];
    }

    public class CAMPOS_DEMANDA
    {
        public required string CAMPO { get; set; }
        public required string VALOR { get; set; }
    }
}
