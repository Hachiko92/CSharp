//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EjercicioEF1._2bis_DataBase_
{
    using System;
    using System.Collections.Generic;
    
    public partial class PedidosSet
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int ClientesId { get; set; }
        public int ProductosId { get; set; }
    
        public virtual ClientesSet ClientesSet { get; set; }
        public virtual ProductosSet ProductosSet { get; set; }
    }
}
