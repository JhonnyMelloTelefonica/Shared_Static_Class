﻿namespace Shared_Razor_Components.FundamentalModels
{
    public class FilterJornadaQuestionsModel
    {
        public bool? IsSuporte { get; set; }
        public required string LOGIN { get; set; }
        public bool? APROVACAO { get; set; }
        public required string REGIONAL { get; set; }
        public string? UF { get; set; }
        public string? DT_SOLICITACAO { get; set; }
    }
}
