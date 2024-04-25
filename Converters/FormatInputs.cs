using System;
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
    }
}
