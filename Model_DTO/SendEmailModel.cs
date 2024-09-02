using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Static_Class.Model_DTO
{
    public class SendEmailModel
    {
        public IEnumerable<string> Para { get; set; } = [];
        public string De { get; set; } = "";
        public string Assunto { get; set; } = string.Empty;
        public string HtmlCorpo { get; set; } = string.Empty;
        public IEnumerable<string> CC { get; set; } = [];
        public IEnumerable<string> Anexos { get; set; } = [];
    }
}
