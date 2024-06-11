using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Shared_Static_Class.Data;
using Shared_Static_Class.Model_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shared_Static_Class.Models
{
    public class DEMANDAS_FILA
    {
        public DEMANDA_SUB_FILA_DTO FILA_DTO { get; set; }
        public int TIPO_FILA { get; set; }
        public string MAT_SOLICITANTE { get; set; } = string.Empty;
        [Required(ErrorMessage = "O TIPO DA FILA É OBRIGATÓRIO")]
        public int SUB_FILA { get; set; }
        public string REGIONAL { get; set; } = string.Empty;
        public string? PROBLEMA { get; set; }
        [Required(ErrorMessage = "Por favor informe algum valor para este campo")]
        public List<CamposDemanda> CAMPOS { get; set; } = new();
        public List<FileDataModel> Arquivos { get; set; } = new List<FileDataModel>();
    }

    public class CamposDemanda
    {
        public int ID_CAMPOS { get; set; }
        public int ID_SUB_FILA { get; set; }
        public string CAMPO { get; set; } = string.Empty;
        public string? MASCARA { get; set; }
        public bool CAMPO_SUSPENSO { get; set; }
        public bool STATUS_CAMPOS_FILA { get; set; }
        [Required]
        public string RESPOSTA { get; set; }
        public List<DEMANDA_VALORES_CAMPOS_SUSPENSO_DTO>? valores { get; set; }

        public string FormatTelefone(string telefone)
        {
            // Remove any non-digit characters
            var numbertelefone = new string(telefone.Where(char.IsDigit).ToArray());
            var countnumbers = numbertelefone.Length;

            // Format as (XX) XXXX-XXXX or (XX) XXXXX-XXXX
            if (countnumbers == 11)
                telefone = $"({numbertelefone.Substring(0, 2)}) {numbertelefone.Substring(2, 5)}-{numbertelefone.Substring(7)}";
            else if (countnumbers == 10)
                telefone = $"({numbertelefone.Substring(0, 2)}) {numbertelefone.Substring(2, 4)}-{numbertelefone.Substring(6)}";
            else if (countnumbers >= 7)
                telefone = $"({numbertelefone.Substring(0, 2)}) {numbertelefone.Substring(2, 4)}-{numbertelefone.Substring(6)}";
            else if (countnumbers >= 3)
                telefone = $"({numbertelefone.Substring(0, 2)}) {numbertelefone.Substring(2)}";
            else if (countnumbers == 2)
                telefone = $"({numbertelefone.Substring(0, 2)})";

            return telefone;
        }



        public string FormatCPF(string cpf)
        {
            // Remove any non-digit characters
            var numbercpf = new string(cpf.Where(char.IsDigit).ToArray());
            var countnumbers = numbercpf.Length;

            // Format as (XX) XXXX-XXXX or (XX) XXXXX-XXXX
            if (countnumbers == 11)
                cpf = $"{numbercpf.Substring(0, 3)}.{numbercpf.Substring(3, 3)}.{numbercpf.Substring(6, 3)}-{numbercpf.Substring(9)}";
            else if (countnumbers >= 10 )
                cpf = $"{numbercpf.Substring(0, 3)}.{numbercpf.Substring(3, 3)}.{numbercpf.Substring(6, 3)}-{numbercpf.Substring(9)}";
            else if (countnumbers >= 7 )
                cpf = $"{numbercpf.Substring(0, 3)}.{numbercpf.Substring(3, 3)}.{numbercpf.Substring(6)}";
            else if (countnumbers >= 4 )
                cpf = $"{numbercpf.Substring(0, 3)}.{numbercpf.Substring(3)}";

            return cpf;
        }

    }


}
