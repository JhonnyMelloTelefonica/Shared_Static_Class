using Newtonsoft.Json;

namespace Shared_Static_Class.Models
{
    public class ControleUsuariosFilterModel
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public IReadOnlyList<string?> Cargo { get; set; } = [];
        public IReadOnlyList<string?> Canal { get; set; } = [];
        public IReadOnlyList<string> Regional { get; set; } = [];
        public IReadOnlyList<string> Uf { get; set; } = [];
        public IReadOnlyList<bool> Fixa { get; set; } = [];
        public string Nome { get; set; } = string.Empty;
        public int? Matricula { get; set; }
        //public string MatriculaDivisao { get; set; } = string.Empty;
        public string MatriculaDivisao { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string Pdv { get; set; } = string.Empty;
        public bool? IsSuporte { get; set; } = null;
    }
}
