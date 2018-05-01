using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class Proyecto
    {
        public String idProyecto { get; set; }
        public String Nombre { get; set; }
        public String PeriodoProyecto { get; set; }
        public int NumeroResidencias { get; set; }
        public String opcionElegida { get; set; }
        public String idEmpresa { get; set; }
        public Proyecto()
        {

        }
        public Proyecto(String idProyecto,String Nombre,String PeriodoProyecto,int NumeroResidencias,String opcionElegida,String idEmpresa)
        {
            this.idProyecto = idProyecto;
            this.Nombre = Nombre;
            this.PeriodoProyecto = PeriodoProyecto;
            this.NumeroResidencias = NumeroResidencias;
            this.opcionElegida = opcionElegida;
            this.idEmpresa = idEmpresa;
        }
    }
}
