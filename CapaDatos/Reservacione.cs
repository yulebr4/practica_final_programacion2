//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservacione
    {
        public int ID { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<int> ClienteID { get; set; }
        public Nullable<int> RestauranteID { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Restaurante Restaurante { get; set; }
    }
}
