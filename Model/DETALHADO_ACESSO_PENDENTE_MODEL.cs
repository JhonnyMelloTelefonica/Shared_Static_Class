using Shared_Static_Class.Converters;
using Shared_Static_Class.Data;
using Shared_Static_Class.Enums;

namespace Shared_Static_Class.Models
{
    public class DETALHADO_ACESSO_PENDENTE_MODEL
    {
        public SOLICITACAO_USUARIO_DETALHADO SOLICITACAO { get; set; }
        public ACESSOS_MOBILE? ACESSOS_MOBILE { get; set; } = null;
        public IEnumerable<MENSAGEM_ACESSO_PENDENTE> RESPOSTAS { get; set; } = [];
    }
}
