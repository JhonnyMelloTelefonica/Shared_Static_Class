using Shared_Static_Class.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Static_Class.Model_DTO.FilterModels
{
    public class FilterDemandaPage
    {
        public List<int> fila_macro { get; set; } = [];
        public List<int> fila { get; set; } = [];
        public List<int> responsável { get; set; } = [];
        public bool Demandas { get; set; } = true;
        public bool Acessos { get; set; } = true;
        public bool Desligamentos { get; set; } = true;
        public Acao AcessoAcao { get; set; }
        public List<string> id_demandas { get; set; } = [];
        public bool Status_ABERTO { get; set; } = false;
        public bool Status_CANCELADO { get; set; } = false;
        public bool Status_REPROVADO { get; set; } = false;
        public bool Status_APROVADO { get; set; } = false;
        public bool Status_REABRIR { get; set; } = false;
        public bool Status_AGUARDANDO_OUTRA_AREA { get; set; } = false;
        public bool Status_AGUARDANDO_ANALISTA { get; set; } = false;
        public bool Status_AGUARDANDO_TREINAMENTO { get; set; } = false;
        public bool Status_AGUARDANDO_CRIAÇÃO_DE_ACESSO { get; set; } = false;
        public bool Status_DEVOLVIDO_PARA_SOLICITANTE { get; set; } = false;

    }
}
