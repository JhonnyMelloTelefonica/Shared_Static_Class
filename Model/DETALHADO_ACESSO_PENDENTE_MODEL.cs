using Shared_Static_Class.Converters;
using Shared_Static_Class.Data;
using Shared_Static_Class.Enums;
using Shared_Static_Class.Model_DTO;
using Shared_Static_Class.Models;

namespace Shared_Static_Class.Models
{
    public class DETALHADO_ACESSO_PENDENTE_MODEL
    {
        public SOLICITACAO_USUARIO_DETALHADO SOLICITACAO { get; set; }
        public ACESSOS_MOBILE? ACESSOS_MOBILE { get; set; } = null;
        public IEnumerable<PERFIL_PLATAFORMAS_VIVO>? PERFIS_ACESSOS_MOBILE { get; set; } = [];
        public IEnumerable<MENSAGEM_ACESSO_PENDENTE> RESPOSTAS { get; set; } = [];
    }
}
