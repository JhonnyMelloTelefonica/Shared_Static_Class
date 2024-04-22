using Shared_Static_Class.Data;

namespace Shared_Static_Class.Models
{
    public class RespostasAcessosPendentesModel
    {
        public int ID { get; set; }
        public int ID_ACESSOS_PENDENTE { get; set; }
        public ACESSOS_MOBILE? MATRICULA { get; set; }
        public string RESPOSTA { get; set; }
        public string STATUS { get; set; }
        public DateTime DATA { get; set; }
    }
}
