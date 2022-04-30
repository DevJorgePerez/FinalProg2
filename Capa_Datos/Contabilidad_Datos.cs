using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;


namespace Capa_Datos
{
    public class Contabilidad_Datos
    {
        contabilidadEntities dbinfo = new contabilidadEntities();

        public void InsertarTipoCuenta( Tipo_de_Cuenta tcuenta) 
        {

            dbinfo.Tipo_de_Cuenta.Add(tcuenta);
            dbinfo.SaveChanges();

        }

        public void InsertarCatalogoCuenta(Catalogo_de_Cuentas cataCuenta)
        {
            dbinfo.Catalogo_de_Cuentas.Add(cataCuenta);
            dbinfo.SaveChanges();
        }


        public void InsertarMoviContable(Movimiento_Contable moviContable) 
        {

            dbinfo.Movimiento_Contable.Add(moviContable);
            dbinfo.SaveChanges();
            
        
        }
    }
}
