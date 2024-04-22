﻿using Shared_Static_Class.Data;

namespace Shared_Static_Class.Models
{
    public class CreateQuestionModel
    {
        public int? TEMA { get; set; }
        public int? SUB_TEMA { get; set; }
        public List<string> TP_FORMS { get; set; } = new();
        public string TP_QUESTAO { get; set; }
        public string PERGUNTA { get; set; }
        public string regional { get; set; }
        public IReadOnlyList<int> CARGO { get; set; } = new List<int>();
        public bool? FIXA { get; set; }
        public List<JORNADA_BD_ANSWER_ALTERNATIVA> ALTERNATIVAS { get; set; } = new();
        public int? matricula { get; set; }
    }
}
