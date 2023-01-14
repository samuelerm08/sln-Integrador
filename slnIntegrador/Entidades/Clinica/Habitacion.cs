using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clinica
{
    public class Habitacion
    {
        public int ID { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }

        public virtual string InfoHabitacion()
        {
            return $"Numero Habitacion: {Numero} | " +
                   $"Estado: {Estado}";
        }
    }
}

