using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Shared_Static_Class.Helpers;

public static class ValidationsHelpers
{
    public class ListHasElements<T> : ValidationAttribute
    {

        readonly int _minCount = 0;
        readonly T ExceptElement;
        public ListHasElements(object exceptelement = null, int mincount = 0)
        {
            if (exceptelement != null)
            {
                ExceptElement = (T)exceptelement;
            }
            _minCount = mincount;
        }
        public override bool IsValid(object? value)
        {
            if (value == null)
                return false;

            if (value is IEnumerable enumerable)
            {
                if (ExceptElement != null)
                    if (enumerable.Cast<T>().Where(x => x != null).Any(x => ExceptElement.Equals(x)))
                        return false;

                if (_minCount != 0)
                    return enumerable.Cast<T>().Where(x => x != null).Count() >= _minCount;

                return enumerable.Cast<T>().Where(x => x != null).Any();
            }
            else return false;
        }
    }

    public class NomeCompletoValidationAttribute : ValidationAttribute
    {
        private static readonly string[] Preposicoes = { "da", "de", "do", "das", "dos" };

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return new ValidationResult("O campo nome é obrigatório.");
            }

            var nome = value.ToString();
            var palavras = nome.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Conta palavras, ignorando preposições
            var palavrasValidas = palavras.Count(p => !Preposicoes.Contains(p.ToLower()));

            if (palavrasValidas < 3)
            {
                return new ValidationResult("O nome deve conter pelo menos três palavras, ignorando preposições como 'da', 'de', 'do', etc.");
            }

            return ValidationResult.Success;
        }
    }
}
