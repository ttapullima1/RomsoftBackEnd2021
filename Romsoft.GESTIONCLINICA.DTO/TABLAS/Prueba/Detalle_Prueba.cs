using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DTO.TABLAS.Prueba
{
    public class Detalle_Prueba
    {
        public string CodVale { get; set; }
        public int id_cabecera { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal CostoTotal { get; set; }
        public int f_estado { get; set; }
    }
}
