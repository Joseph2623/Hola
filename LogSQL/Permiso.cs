//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogSQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Permiso
    {
        public int IdPermiso { get; set; }
        public int RolUsuId { get; set; }
        public int OpcionId { get; set; }
        public bool Permitido { get; set; }
    
        public virtual Opcion Opcion { get; set; }
        public virtual RolUsuario RolUsuario { get; set; }
    }
}
