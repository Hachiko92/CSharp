//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto50EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Animal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PersonaID { get; set; }
        public string ClaseAnimalID { get; set; }
    
        public virtual Persona Persona { get; set; }
        public virtual ClaseAnimal ClaseAnimal { get; set; }
    }
}
