using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_PRESTACION
{
    public class ADM_DOCUMENTO_PRESTACION
    {
        public int id_documento_prestacion { get; set; }
		public string c_codigo { get; set; }
		public string c_codigo_susalud { get; set; }
		public string t_descripcion { get; set; }
    }
}
