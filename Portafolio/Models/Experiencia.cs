//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portafolio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Experiencia
    {
        public string id { get; set; }
        public string UsuarioID { get; set; }
        public string Tipo_ID { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public string Descripcion { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Tipo Tipo { get; set; }
    }
}
