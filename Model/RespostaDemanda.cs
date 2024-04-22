﻿using Shared_Static_Class.Data;

namespace Shared_Static_Class.Models
{
    public class RespostaDemanda
    {
        public int ID { get; set; }
        public string RESPOSTA { get; set; }
        public int ID_CHAMADO { get; set; }
        public ACESSO? RESPONSAVEL { get; set; }
        public DateTime? DATA_RESPOSTA { get; set; }
        public IEnumerable<CONTROLE_DEMANDAS_ARQUIVOS_RESPOSTum_DTO>? ANEXOS { get; set; }
    }
}
