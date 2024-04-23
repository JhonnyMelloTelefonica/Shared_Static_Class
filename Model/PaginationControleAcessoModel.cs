﻿using System.Collections.Generic;

namespace Shared_Static_Class.Models
{
    public class PaginationControleAcessoModel
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Nome { get; set; }

        //public string? MatriculaDivisao { get; set; }
        public string MatriculaDivisao { get; set; }
        public int? Matricula { get; set; }
        public string? Pdv { get; set; }
        public string? email { get; set; }
        public bool? IsSuporte { get; set; }
        public List<string>? Cargo { get; set; }
        public List<string>? Canal { get; set; }
        public List<string>? Regional { get; set; }
        public List<string>? Uf { get; set; }
        public List<bool>? Fixa { get; set; }

    }
}