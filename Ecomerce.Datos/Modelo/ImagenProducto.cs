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
    
    public partial class ImagenProducto
    {
        public int IdImagenProducto { get; set; }
        public int IdProducto { get; set; }
        public string Url { get; set; }
        public bool EsPortada { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}
