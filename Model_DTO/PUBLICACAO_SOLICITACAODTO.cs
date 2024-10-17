using Shared_Razor_Components.FundamentalModels;
using Shared_Static_Class.Model_ForumRTCZ_Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Static_Class.Model_DTO
{
    public class PUBLICACAO_SOLICITACAODTO : PUBLICACAO_SOLICITACAO
    {
        public PUBLICACAO_SOLICITACAODTO(PUBLICACAO_SOLICITACAO item, bool showRespostas = false, bool selected = false) : base(item.ID_SOLICITACAO_PUBLICACAO, item.TEXT_PUBLICACAO, item.SUB_TEMA, item.MAT_RESPONSAVEL, item.HORA)
        {
            ID_SOLICITACAO_PUBLICACAO = item.ID_SOLICITACAO_PUBLICACAO;
            TEXT_PUBLICACAO = item.TEXT_PUBLICACAO;
            SUB_TEMA = item.SUB_TEMA;
            MAT_RESPONSAVEL = item.MAT_RESPONSAVEL;
            HORA = item.HORA;
            Responsavel = item.Responsavel;
            Tema = item.Tema;
            Avaliacao = item.Avaliacao ?? [];
            Respostas = item.Respostas ?? [];
            ShowRespostas = showRespostas;
            Selected = selected;
        }
        public bool ShowRespostas { get; set; }
        public bool Selected { get; protected set; }
        public int ActualAvaliacao { get; set; }

        public void SetSelected()
        {
            Selected = !Selected;
        }
    }
}
