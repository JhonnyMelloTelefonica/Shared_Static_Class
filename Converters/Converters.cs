
using Shared_Static_Class.Converters;
using Shared_Static_Class.Enums;
using Shared_Static_Class.Models;
using System.Data;

namespace Shared_Static_Class.Converters
{
    public static class Converters
    {
        public static List<string> ConvertStringToStringList(string input)
        {
            var enumList = new List<string>();

            if (!string.IsNullOrEmpty(input))
            {
                if (input.Contains(";"))
                {
                    // Multiple values separated by semicolon
                    var enumValues = input.Split(';').Select(x => x.Trim());

                    foreach (var value in enumValues)
                    {
                        enumList.Add(value);
                    }
                }
                else
                {
                    enumList.Add(input);
                }
            }

            return enumList;
        }
        
        public static string RemoveNonNumericCharacters(string input) => new string(input.ToCharArray().Where(c => char.IsDigit(c)).ToArray());
        public static List<TEnum> ConvertStringToEnumList<TEnum>(string input) where TEnum : struct
        {
            var enumList = new List<TEnum>();

            if (!string.IsNullOrEmpty(input))
            {
                if (input.Contains(";"))
                {
                    // Multiple values separated by semicolon
                    var enumValues = input.Split(';').Select(x => x.Trim());

                    foreach (var value in enumValues)
                    {
                        if (Enum.TryParse(typeof(TEnum), value, out var categoriaValue) && categoriaValue is TEnum)
                        {
                            enumList.Add((TEnum)categoriaValue);
                        }
                        else
                        {
                            // Handle the case where parsing fails or provide a default value
                        }
                    }
                }
                else
                {
                    // Single value without semicolon
                    if (Enum.TryParse(typeof(TEnum), input.Trim(), out var categoriaValue) && categoriaValue is TEnum)
                    {
                        enumList.Add((TEnum)categoriaValue);
                    }
                    else
                    {
                        // Handle the case where parsing fails or provide a default value
                    }
                }
            }

            return enumList;
        }
        public static IEnumerable<Cargos> GetCargosFromStringList(string cargo)
        {
            var delimiter = new[] { ';' };
            var cargosArray = cargo.Split(delimiter, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(x => (Cargos)int.Parse(x))
                                   .ToList();

            return cargosArray;
        }
        public static IEnumerable<Canal> GetCanaisFromCargos(string cargo)
        {
            var cargosList = GetCargosFromStringList(cargo);
            var canaisArray = cargosList.Select(x => DePara.CanalCargoEnum(x)).ToList();

            return canaisArray;
        }

    }
}
