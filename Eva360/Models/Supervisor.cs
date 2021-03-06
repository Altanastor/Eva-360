//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eva360.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supervisor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supervisor()
        {
            this.EmpleadoPeriodo = new HashSet<EmpleadoPeriodo>();
            this.Evaluacion = new HashSet<Evaluacion>();
        }
    
        public int SupervisorId { get; set; }
        public int UsuarioCreacionId { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<int> UsuarioModificacionId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoPeriodo> EmpleadoPeriodo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluacion> Evaluacion { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
