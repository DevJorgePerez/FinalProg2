using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;


namespace Capa_Negocios
{

    
    public class Contabilidad_Negocios
    
    {
        Contabilidad_Datos objContaDatos = new Contabilidad_Datos();

        public void InsertTypeConta(Tipo_de_Cuenta tCuenta2)
        {

            objContaDatos.InsertarTipoCuenta(tCuenta2);
        }

        public void InsertCataAccount(Catalogo_de_Cuentas catacuenta2) 
        {
            objContaDatos.InsertarCatalogoCuenta(catacuenta2);
        
        }

        public void InsertMoveConta(Movimiento_Contable movecuenta)
        {
            objContaDatos.InsertarMoviContable(movecuenta);
        }

    }
}
