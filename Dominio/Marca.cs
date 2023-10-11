using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int _idMarca { get; set; }
        public string _nombre { get; set; }

        public override string ToString()
        {
            return _nombre;
        }

    }
}
