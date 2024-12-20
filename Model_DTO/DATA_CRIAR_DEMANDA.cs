using Shared_Static_Class.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Static_Class.Model_DTO
{
    public class DATA_CRIAR_DEMANDA
    {
        public IEnumerable<JORNADA_BD_HIERARQUIum> Carteira { get; set; }
        public IEnumerable<CNS_BASE_TERCEIROS_SAP_GT> Sap { get; set; }
    }
}
