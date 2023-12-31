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
    
    public partial class Empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleados()
        {
            this.Usuarios = new HashSet<Usuarios>();
        }
    
        public long id { get; set; }
        public string cedula { get; set; }
        public string primer_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_nombre { get; set; }
        public string segundo_apellido { get; set; }
        public System.DateTime fecha_nac { get; set; }
        public string lugar_nac { get; set; }
        public int edad { get; set; }
        public string nacionalidad { get; set; }
        public string sexo { get; set; }
        public string estado_civil { get; set; }
        public string grupo_sanguineo { get; set; }
        public string telefono_movil { get; set; }
        public string telefono_hab { get; set; }
        public string direccion_hab { get; set; }
        public string e_mail { get; set; }
        public System.DateTime fecha_ingreso { get; set; }
        public string nombreimagen { get; set; }
        public long Departamento_id { get; set; }
        public long SubDepartamento_id { get; set; }
        public long Cargo_id { get; set; }
        public string candado_serial { get; set; }
        public bool inactivo { get; set; }
        public bool usamerulink { get; set; }
        public bool usaHID { get; set; }
        public bool usaLocker { get; set; }
        public long Locker_id { get; set; }
        public bool usatransportemeru { get; set; }
        public string destino { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual Cargos Cargos { get; set; }
        public virtual Cargos Cargos1 { get; set; }
        public virtual Departamentos Departamentos { get; set; }
        public virtual Departamentos Departamentos1 { get; set; }
        public virtual sub_departamentos sub_departamentos { get; set; }
        public virtual sub_departamentos sub_departamentos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
