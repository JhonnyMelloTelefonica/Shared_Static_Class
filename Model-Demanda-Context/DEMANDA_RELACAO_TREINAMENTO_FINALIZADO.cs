using Newtonsoft.Json;
using Shared_Static_Class.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Static_Class.Model_Demanda_Context
{
    [Table("DEMANDA_RELACAO_TREINAMENTO_FINALIZADO", Schema = "Demandas")]
    public class DEMANDA_RELACAO_TREINAMENTO_FINALIZADO
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(10)]
        public int MATRICULA { get; set; }
        [Required]
        public int ID_RELACAO { get; set; }
        [Required]
        [MaxLength(255)]
        public string Nome { get; set; } = string.Empty;
        [Required]
        public DateTime Data_Admissão { get; set; }
        [Required]
        public string Cargo { get; set; } = string.Empty;
        [Required]
        public string Empresa { get; set; } = string.Empty;
        [Required]
        [MaxLength(19)]
        public string CNPJ { get; set; } = string.Empty;
        [Required]
        public string Canal { get; set; } = string.Empty;
        [Required]
        [MaxLength(3)]
        public string Uf { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string Cidade { get; set; } = string.Empty;
        [Required]
        public DateTime Data_Conclusao { get; set; }
        [Required]
        [MaxLength(10)]
        [AllowedValues("ATIVO","INATIVO", ErrorMessage = "Valor inválido")]
        public string STATUS_MATRICULA { get; set; } = "INATIVO";

        [ForeignKey("ID_RELACAO")]
        [JsonIgnore]
        public virtual DEMANDA_ACESSOS DemandaAcesso { get; set; }
    }
}
