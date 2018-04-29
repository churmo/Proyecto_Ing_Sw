using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class Empresa
    {
        public String idEmpresa { get; set; }
        public String giraRamaSector { get; set; }
        public String otrogrs { get; set; }
        public String rfc { get; set; }
        public String cp { get; set; }
        public String domicilio { get; set; }
        public String fax { get; set; }
        public String colonia { get; set; }
        public String telefono { get; set; }
        public String MisionEmpresa { get; set; }
        public String NombreTitularEmpresa { get; set; }
        public String PuestoTitularEmpresa { get; set; }
        public String NombreAsesorExterno { get; set; }
        public String PuestoAsesorExterno { get; set; }
        public String NombrePersonaFirma { get; set; }
        public String PuestoPersonaFirma { get; set; }

        public Empresa(String idEmpresa, String giraRamaSector,String otrogrs,String rfc,String cp,String domicilio,String fax,String colonia,String telefono, String MisionEmpresa,String NombreTitularEmpresa,String PuestoTitularEmpresa,String NombreAsesorExterno,String PuestoAsesorExterno,String NombrePersonaFirma,String PuestoPersonaFirma)
        {
            this.idEmpresa = idEmpresa;
            this.giraRamaSector = giraRamaSector;
            this.otrogrs = otrogrs;
            this.rfc = rfc;
            this.cp = cp;
            this.domicilio = domicilio;
            this.fax = fax;
            this.colonia = colonia;
            this.telefono = telefono;
            this.MisionEmpresa = MisionEmpresa;
            this.NombreTitularEmpresa = NombreTitularEmpresa;
            this.PuestoTitularEmpresa = PuestoTitularEmpresa;
            this.NombreAsesorExterno = NombreAsesorExterno;
            this.PuestoAsesorExterno = PuestoAsesorExterno;
            this.NombrePersonaFirma = NombrePersonaFirma;
            this.PuestoPersonaFirma = PuestoPersonaFirma;
        }
    }
}
