﻿using Shared_Static_Class.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Static_Class.Model_ForumRTCZ_Context;

[Table("FORUM_PUBLICACAO", Schema = "Fórum")]
public partial class RESPOSTA_PUBLICACAO
{
    public RESPOSTA_PUBLICACAO()
    {

    }

    public RESPOSTA_PUBLICACAO(Guid iD_PUBLICACAO, Guid iD_SOLICITACAO_PUBLICACAO, DateTime hORA, int mAT_SOLICITANTE, string tEXT_PUBLICACAO)
    {
        ID_PUBLICACAO = iD_PUBLICACAO;
        ID_SOLICITACAO_PUBLICACAO = iD_SOLICITACAO_PUBLICACAO;
        HORA = hORA;
        MAT_SOLICITANTE = mAT_SOLICITANTE;
        TEXT_PUBLICACAO = tEXT_PUBLICACAO;
    }

    [Key]
    public Guid ID_PUBLICACAO { get; set; }
    public Guid ID_SOLICITACAO_PUBLICACAO { get; set; }
    public DateTime HORA { get; set; }
    public int MAT_SOLICITANTE { get; set; }
    public string TEXT_PUBLICACAO { get; set; }
    public List<AVALIACAO_PUBLICACAO> Avaliacao { get; set; } = [];
    public ACESSOS_MOBILE Solicitante { get; set; } = null;
    public PUBLICACAO_SOLICITACAO Publicacao_alvo { get; set; } = null;
}
