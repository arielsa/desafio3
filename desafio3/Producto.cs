using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio3
{
    public class Producto : ICloneable
    {
        public Id Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public Producto(Id id, string descripcion = "", decimal precio=0, int stock=0)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Producto CloneCasteado(Producto pProducto)
        {
            Producto p = (Producto)pProducto.Clone();
            return p;
        }
    }
}
