//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class permisos_descripcion
    {
        public long id { get; set; }
        public string descripcion { get; set; }
        public int permissions_id { get; set; }
    
        public virtual permissions permissions { get; set; }
    }
}
