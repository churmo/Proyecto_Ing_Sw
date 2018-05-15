using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class Proyecto
    {
       
        public String idNombre { get; set; }
        public String PeriodoProyecto { get; set; }
        public int NumeroResidencias { get; set; }
        public String opcionElegida { get; set; }
       
        public Proyecto()
        {

        }
        public Proyecto(String idNombre,String PeriodoProyecto,int NumeroResidencias,String opcionElegida)
        {
            
            this.idNombre = idNombre;
            this.PeriodoProyecto = PeriodoProyecto;
            this.NumeroResidencias = NumeroResidencias;
            this.opcionElegida = opcionElegida;
        }
    }
}
