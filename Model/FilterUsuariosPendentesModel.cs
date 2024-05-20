using Shared_Static_Class.Converters;
using Shared_Static_Class.Enums;

namespace Shared_Static_Class.Models
{
    public class FilterUsuariosPendentesModel
    {
        public List<string> ID { get; set; } = [];
        public bool? IsSuporte { get; set; }
        public bool IsMaster { get; set; }
        public string? NomeSolicitante { get; set; }
        public List<int?> MATRICULA { get; set; } = [];
        public List<int?> LOGIN_SOLICITANTE { get; set; } = [];
        public List<string?> UF { get; set; } = [];
        public List<string?> REGIONAL { get; set; } = [];
        public List<string?> Tipo { get; set; } = [];
        public List<string> REGIONAIS_FILTER { get; set; } = []; 
        public List<string?> STATUS { get; set; } = [];
        public List<Canal> Canal { get; set; } = [];
        public List<Cargos> Cargos { get; set; } = [];
        public bool APROVACAO { get; set; }
        public IReadOnlyList<DateTime?> DT_SOLICITACAO { get; set; } = new List<DateTime?>();
    }
}
