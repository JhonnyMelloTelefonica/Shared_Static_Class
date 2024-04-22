using System.Text.Json.Serialization;

namespace Shared_Static_Class.Model_DTO
{
    public class PaginationFilaDemandasModel
    {
        public string id_fila { get; set; }
        public string nome_fila { get; set; }
        public IReadOnlyList<string> regional { get; set; }
        public List<string> campos { get; set; } = new List<string>();
        public List<ACESSOS_MOBILE_DTO> responsável { get; set; }  = new List<ACESSOS_MOBILE_DTO>();
        public List<DEMANDA_SUB_FILA_DTO> fila { get; set; }  = new List<DEMANDA_SUB_FILA_DTO>();
        public List<DEMANDA_TIPO_FILA_DTO> tipo_fila { get; set; }  = new List<DEMANDA_TIPO_FILA_DTO>();
    }
}
