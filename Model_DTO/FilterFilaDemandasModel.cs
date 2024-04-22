
namespace Shared_Static_Class.Model_DTO
{
    public class FilterFilaDemandasModel
    {
        public IEnumerable<DEMANDA_TIPO_FILA_DTO> filas { get; set; } = new List<DEMANDA_TIPO_FILA_DTO>();
        public IEnumerable<ACESSOS_MOBILE_DTO> AnalistaSuporte { get; set; } = new List<ACESSOS_MOBILE_DTO>();
    }
}
