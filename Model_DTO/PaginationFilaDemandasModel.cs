using System.Drawing;
using System.Text.Json.Serialization;

namespace Shared_Static_Class.Model_DTO
{
    public class PaginationFilaDemandasModel
    {
        public string id_fila { get; set; } = string.Empty;
        public string nome_fila { get; set; } = string.Empty;
        public IReadOnlyList<string> regional { get; set; } = [];
        public List<string> campos { get; set; } = [];
        public List<int> responsável { get; set; } = [];
        public List<int> fila_macro { get; set; } = [];
        public List<int> sub_fila { get; set; } = [];
        public List<int> idSub { get; set; } = [];
        public List<bool> status { get; set; } = [true];

        public class STATUS
        {
            public string? NomeStatus { get; set; }
            public bool? valor { get; set; }
        }
       public List<STATUS> statusOptions = new List<STATUS>
        {
         new STATUS{ NomeStatus="ABERTO", valor=true},
         new STATUS{ NomeStatus="FECHADO", valor=false}
        };

        
    }
}
