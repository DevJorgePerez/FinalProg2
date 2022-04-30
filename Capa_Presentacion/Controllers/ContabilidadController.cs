using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocios;

namespace Capa_Presentacion.Controllers
{

    public class ContabilidadController : Controller
    {

        Contabilidad_Negocios nego = new Contabilidad_Negocios();
        Contabilidad_Negocios nego1 = new Contabilidad_Negocios();
        Contabilidad_Negocios nego2 = new Contabilidad_Negocios();


        // GET: Contabilidad
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult TipoCuenta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TipoCuenta(Tipo_de_Cuenta tc)
        {
            nego.InsertTypeConta(tc);
            return View();
        }

        public ActionResult CatalogoCuenta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CatalogoCuenta(Catalogo_de_Cuentas cc)
        {
            nego1.InsertCataAccount(cc);
            return View();
        }

        public ActionResult Movimientocontable()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Movimientocontable(Movimiento_Contable mc)

        {
            nego2.InsertMoveConta(mc);
            return View();
        }






    }
}