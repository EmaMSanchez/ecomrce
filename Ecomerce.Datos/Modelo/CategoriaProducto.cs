//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ecomerce.Datos.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class CategoriaProducto
    {
        public int IdCategoriaProducto { get; set; }
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
