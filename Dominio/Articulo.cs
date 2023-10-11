using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio
{
    public class Articulo
    {
        public int ID { get; set; }

        [DisplayName ("Código")]
        public string _codArticulo { get; set; }

        [DisplayName("Descripción")]
        public string _descripcion { get; set; }

        [DisplayName("Nombre")]
        public string _nombre { get; set; }

        [DisplayName("Categoría")]
        public Categoria _categoria { get; set; }

        [DisplayName("Marca")]
        public Marca _marca { get; set; }

        [DisplayName("Precio")]
        public float _precio { get; set; }

        [DisplayName("UrlImagen")]
        public string _UrlImagen { get; set; }

        public override string ToString()
        {
            return _categoria._descripcion;
        }
   
    }
}
