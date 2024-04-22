using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shared_Static_Class.Models
{
    public class RespostaDemandaModel
    {
        public string resposta { get; set; }
        public int IdChamado { get; set; }
        public int MATRICULA { get; set; }
        public int? MATRICULA_REDIRECIONADO { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; } = string.Empty;
        public List<FileDataModel> Arquivos { get; set; } = new();
    }
}