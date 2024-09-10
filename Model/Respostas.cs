﻿using System.Collections.Generic;

namespace Shared_Razor_Components.FundamentalModels
{
    public class Respostas
    {
        public List<Resposta> RESPOSTAS { get; set; }
    }
    public class Resposta
    {
        public string ID_QUESTION { get; set; }
        public int ID_PROVA { get; set; }
        public string TEMA { get; set; }
        public string TP_FORMS { get; set; }
        public string PESO { get; set; }
        public string PUBLICO_CANAL { get; set; }
        public string PUBLICO_CARGO { get; set; }
        public string CADERNO { get; set; }
        public string DT_AVALIACAO { get; set; }
        public string MATRICULA_APLICADOR { get; set; }
        public string RESPOSTA_USER { get; set; }
        public bool STATUS_RESPOSTA { get; set; }
        public string REDE_AVALIADA { get; set; }
        public string DDD_AVALIADO { get; set; }
        public string PDV_AVALIADO { get; set; }
        public string RE_AVALIADO { get; set; }
    }
}

//"ID_QUESTION":"",
//"ID_PROVA":2,
//"TEMA":"",
//"TP_FORMS":"",
//"PESO":"",
//"PUBLICO_CANAL":"",
//"PUBLICO_CARGO":"",
//"CADERNO":"",
//"DT_AVALIACAO":"",
//"MATRICULA_APLICADOR":"",
//"RESPOSTA_USER":"",
//"STATUS_RESPOSTA":false,
//"REDE_AVALIADA":"",
//"DDD_AVALIADO":"",
//"PDV_AVALIADO":"",
//"REDE_AVALIADO":"",
//"RE_AVALIADO":"",
