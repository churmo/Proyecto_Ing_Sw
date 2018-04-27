using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class Empresa
    {
        int idEmpresa { get; set; }
        String giraRamaSector { get; set; }
        String otrogrs { get; set; }
        String rfc { get; set; }
        String cp  { get; set; }
        String  domicilio { get; set; }
        String  fax { get; set; }
        String colonia  { get; set; }
    String telefono { get; set; }
    String MisionEmpresa { get; set; }
    String NombreTitularEmpresa { get; set; }
    String PuestoTitularEmpresa { get; set; }
    String NombreAsesorExterno { get; set; }
    String PuestoAsesorExterno { get; set; }
    String NombrePersonaFirma { get; set; }
    String PuestoPersonaFirma { get; set; }

        Empresa() { }
        Empresa(int idEmpresa,String giraRamaSector,String otrogrs,String rfc, String cp,String domicilio,String fax,String colonia,String telefono,String MisionEmpresa,
            String NombreTitularEmpresa,String PuestoTitularEmpresa,String NombreAsesorEcterno,String PuestoAsesorEcterno,String NombrePersonafirma,
            String PuestoPersonaFirma) {
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
