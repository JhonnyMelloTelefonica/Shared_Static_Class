﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Static_Class.Converters
{
    public static class FormatInputs
    {
        public static string FormatTelefone(string telefone)
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

        public static string FormatCPF(string cpf)
        {
            // Remove any non-digit characters
            var numbercpf = new string(cpf.Where(char.IsDigit).ToArray());
            var countnumbers = numbercpf.Length;

            // Format as (XX) XXXX-XXXX or (XX) XXXXX-XXXX
            if (countnumbers == 11)
                cpf = $"{numbercpf.Substring(0, 3)}.{numbercpf.Substring(3, 3)}.{numbercpf.Substring(6, 3)}-{numbercpf.Substring(9)}";
            else if (countnumbers >= 10)
                cpf = $"{numbercpf.Substring(0, 3)}.{numbercpf.Substring(3, 3)}.{numbercpf.Substring(6, 3)}-{numbercpf.Substring(9)}";
            else if (countnumbers >= 7)
                cpf = $"{numbercpf.Substring(0, 3)}.{numbercpf.Substring(3, 3)}.{numbercpf.Substring(6)}";
            else if (countnumbers >= 4)
                cpf = $"{numbercpf.Substring(0, 3)}.{numbercpf.Substring(3)}";

            return cpf;
        }

        public static string FormatCNPJ(string cnpj)
        {
            // Remove any non-digit characters
            var numberCNPJ = new string(cnpj.Where(char.IsDigit).ToArray());
            var countNumbers = numberCNPJ.Length;

            // Format as XX.XXX.XXX/XXXX-XX
            string formattedCNPJ = numberCNPJ;
            if (countNumbers >= 14)
                formattedCNPJ = $"{numberCNPJ.Substring(0, 2)}.{numberCNPJ.Substring(2, 3)}.{numberCNPJ.Substring(5, 3)}/{numberCNPJ.Substring(8, 4)}-{numberCNPJ.Substring(12, 2)}";
            else if (countNumbers >= 12)
                formattedCNPJ = $"{numberCNPJ.Substring(0, 2)}.{numberCNPJ.Substring(2, 3)}.{numberCNPJ.Substring(5, 3)}/{numberCNPJ.Substring(8, 4)}-{numberCNPJ.Substring(12)}";
            else if (countNumbers >= 8)
                formattedCNPJ = $"{numberCNPJ.Substring(0, 2)}.{numberCNPJ.Substring(2, 3)}.{numberCNPJ.Substring(5, 3)}/{numberCNPJ.Substring(8)}";
            else if (countNumbers >= 5)
                formattedCNPJ = $"{numberCNPJ.Substring(0, 2)}.{numberCNPJ.Substring(2, 3)}.{numberCNPJ.Substring(5)}";
            else if (countNumbers >= 3)
                formattedCNPJ = $"{numberCNPJ.Substring(0, 2)}.{numberCNPJ.Substring(2)}";

            // Ensure the formatted CNPJ does not exceed the maximum length
            if (formattedCNPJ.Length > 18)
            {
                formattedCNPJ = formattedCNPJ.Substring(0, 18);
            }

            return formattedCNPJ;
        }
    }
}
