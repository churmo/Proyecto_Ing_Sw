using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class RevisarDoc
    {
        public int idDocumento { get; set; }
        public int Calificacion { get; set; }
        public String Notas { get; set; }
        public String idRevisor { get; set; }
        public String idResidente { get; set; }
        public RevisarDoc()
        {

        }
        public RevisarDoc(int idDocumento,int Calificacion,String Notas,String idRevisor,String idResidente)
        {
            this.idDocumento = idDocumento;
            this.Calificacion = Calificacion;
            this.Notas = Notas;
            this.idRevisor = idRevisor;
            this.idResidente = idResidente;
        }
    }
}
