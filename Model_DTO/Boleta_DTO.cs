using Shared_Static_Class.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Static_Class.Model_DTO
{
    public class BOLETA_PALITAGEM_DTO_Unvalidated : BOLETA_PALITAGEM_DTO { }
    public class BOLETA_PALITAGEM_DTO
    {
        public int ID_BOLETA { get; set; }
        public ACESSOS_MOBILE_DTO? MAT_CONSULTOR { get; set; }
        public DateTime DATA_INICIO { get; set; }
        public decimal? TOTAL_PAGAMENTO { get; set; }
        public int? MET_PAGAMENTO { get; set; }
        public DateTime? DT_PRIMEIRO_RETORNO { get; set; }
        public string? STATUS { get; set; }
        public DateTime? DT_RETORNO { get; set; }
        public int? MAT_ANALISTA { get; set; }
        public string PDV { get; set; }
        public int ID_BOLETA_PDV { get; set; }
        public List<HISTORICO_BOLETA_BD_PALITAGEM_DTO>? HISTORICO_BOLETA_BD_PALITAGEMs { get; set; }
        public BOLETA_CLIENTE_DTO? BOLETA_BD_CLIENTEs { get; set; }
        public List<BOLETA_BLOCAO_DTO>? BOLETA_BD_BLOCAOs { get; set; }
        
    }

    public partial class BOLETA_BLOCAO_DTO
    {
        public int ID_BLOCAO_BOLETA { get; set; }
        public int ID_BOLETA { get; set; }

        public List<BOLETA_DADO_DTO> BOLETA_BD_DADOs { get; set; }
    }

    public partial class BOLETA_CLIENTE_DTO
    {
        public int ID_CLIENTE_BOLETA { get; set; }
        public int ID_BOLETA { get; set; }
        [Required(ErrorMessage = "Nome do cliente é obrigatório")]
        public string? NOME { get; set; }
        [Required(ErrorMessage = "CPF/CNPJ do cliente é obrigatório")]
        public string? CPF_CNPJ { get; set; }
        [Required(ErrorMessage = "Telefone do Cliente é obrigatório")]
        public string? TELEFONE { get; set; }
        [Required(ErrorMessage = "Senha GSS é obrigatório")]
        public string SENHA_GSS { get; set; }

    }

    public partial class BOLETA_DADO_DTO
    {
        public int ID_DADOS_BOLETA { get; set; }
        public int ID_BOLETA { get; set; }
        [Required(ErrorMessage = "Plataforma é obrigatório")]
        public Plataforma PLATAFORMA { get; set; }
        [Required(ErrorMessage = "Movimento é obrigatório")]
        public Movimento MOVIMENTO { get; set; }
        [Required(ErrorMessage = "Categoria é obrigatório")]
        public Categoria CATEGORIA { get; set; }
        [Required(ErrorMessage = "Plano é obrigatório")]
        public Planos PLANO { get; set; }
        [Required(ErrorMessage = "Portabilidade é obrigatório")]
        public bool? PORTABILIDADE { get; set; } = false;
        [Required(ErrorMessage = "Fidelização é obrigatório")]
        public bool? FIDELIZACAO { get; set; } = false;
        [Required(ErrorMessage = "Descrição é obrigatório")]
        public string? DESCRICAO { get; set; }
        [Required(ErrorMessage = "SVA é obrigatório")]
        public bool? SVA { get; set; } = false;
        public BOLETA_EQUIPAMENTO_DTO? BOLETA_BD_EQUIPAMENTOs { get; set; }
        public BOLETA_LINHA_DTO? BOLETA_BD_LINHAs { get; set; }
        public BOLETA_SVA_DTO? BOLETA_BD_SVAs { get; set; }
    }

    public partial class BOLETA_EQUIPAMENTO_DTO
    {
        public int ID_EQUIPAMENTO_BOLETA { get; set; }
        public int ID_DADOS_BOLETA { get; set; }
        [Required(ErrorMessage = "Modelo é obrigatório", AllowEmptyStrings = false)]
        public string? MODELO { get; set; }
        [Required(ErrorMessage = "IMEI é obrigatório")]
        public string? IMEI { get; set; }
        [Required(ErrorMessage = "Material é obrigatório")]
        public string? MATERIAL { get; set; }
        [Required(ErrorMessage = "Faturamento do equipamento é obrigatório")]
        public string? FATURAMENTO { get; set; }
        [Required(ErrorMessage = "Nota fiscal do equipamento é obrigatório")]
        public string? NOTA_FISCAL { get; set; }
        [Required(ErrorMessage = "Valor do equipamento é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Valor de equipamento é obrigatório")] 
        public decimal? VALOR { get; set; }

    }

    public partial class BOLETA_LINHA_DTO
    {
        public int ID_LINHA_BOLETA { get; set; }
        public int ID_DADOS_BOLETA { get; set; }
        [Required(ErrorMessage = "Número da linha é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Número da linha é obrigatório")] 
        public int? NUMERO_LINHA { get; set; }
        [Required(ErrorMessage = "Número provisório é obrigatório")]
        public int? NUMERO_PROVISORIO { get; set; }
        [Required(ErrorMessage = "ICCID é obrigatório")]
        public string? ICCID { get; set; }
        [Required(ErrorMessage = "Material é obrigatório")]
        public string? MATERIAL { get; set; }
        [Required(ErrorMessage = "Faturamento é obrigatório")]
        public string? FATURAMENTO { get; set; }
        [Required(ErrorMessage = "Nota Fiscal é obrigatório")]
        public string? NOTA_FISCAL { get; set; }
        [Required(ErrorMessage = "Valor-Linha é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Valor mínimo da linha inválido")]
        public decimal? VALOR { get; set; }
        [Required(ErrorMessage = "Data de Vencimento é obrigatório")]
        public DateTime? DATA_VENC_FAT { get; set; }
        [Required(ErrorMessage = "Operadora Doadora é obrigatório", AllowEmptyStrings = false)]
        public string OPERA_DOA { get; set; }
    }

    public partial class BOLETA_SVA_DTO
    {
        public int ID_SVA_BOLETA { get; set; }
        public int ID_DADOS_BOLETA { get; set; }
        [Required(ErrorMessage = "Serviço atrelado é obrigatório", AllowEmptyStrings = false)] 
        public SVA NOME { get; set; }
        [Required(ErrorMessage = "Valor do serviço atrelado é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Valor de SVA é obrigatório")] 
        public decimal? VALOR { get; set; }
    }

    public partial class HISTORICO_BOLETA_BD_PALITAGEM_DTO
    {
        public int ID_HISTORICO_BOLETA { get; set; }
        public int ID_BOLETA { get; set; }
        public ACESSOS_MOBILE? MATRICULA { get; set; }
        public string? RESPOSTA { get; set; }
        public string? STATUS { get; set; }
        public DateTime? DATA { get; set; }
    }

    public partial class BOLETA_MOVIMENTO_DTO
    {
        public Movimento ID_MOVIMENTO { get; set; }
        public string MOVIMENTO { get; set; }
        public List<Categoria> ID_CATEGORIA { get; set; }
        public List<Plataforma> ID_PLATAFORMA { get; set; }
        public bool DESCRICAO { get; set; }
        public bool PLANO { get; set; }
        public bool PORTABLIDADE { get; set; }
        public bool FIDELIZACAO { get; set; }
        public bool VIVO_TOTAL { get; set; }
        public bool COD { get; set; }
        public bool DAUTO { get; set; }
    }
    public partial class BOLETA_CATEGORIA_DTO
    {
        public Categoria ID_CATEGORIA { get; set; }
        public string CATEGORIA { get; set; }
        public List<Plataforma> ID_PLATAFORMA { get; set; }
        public bool MOVIMENTO { get; set; }
    }

    public partial class BOLETA_PLANO_DTO
    {
        public Planos ID_PLANO { get; set; }
        public string PLANO { get; set; }
        public List<Plataforma> ID_PLATAFORMA { get; set; }
        public string TP_Cliente { get; set; }
        public Plataforma Origem { get; set; }
    }
}
