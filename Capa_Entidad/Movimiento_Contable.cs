//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movimiento_Contable
    {
        public int Cod_mov { get; set; }
        public string Descripcion { get; set; }
        public int cod_catalogo { get; set; }
        public string Tipo_movimiento { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> Debe { get; set; }
        public Nullable<int> Haber { get; set; }
        public string Estado { get; set; }
    
        public virtual Catalogo_de_Cuentas Catalogo_de_Cuentas { get; set; }
    }
}
