using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.SqlServer.Server;

namespace Datos
{
    public static class DacMedico
    {
        public static List<Medico> medicos= new List<Medico>();

        public static List<Medico> Select()
        {
            //TODO - Falta Implementar
            return null;
        }

        public static List<Medico> Select(string especialidad)
        {
            //TODO - Falta Implementar
            return null;
        }
        
        public static int Insert(int id)
        {
            //TODO - Falta Implementar
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO - Falta Implementar
            return 0;
        }

        public static Medico SelectById(int id)
        {
            //TODO - Falta Implementar
            return null;
        }
    }
}
