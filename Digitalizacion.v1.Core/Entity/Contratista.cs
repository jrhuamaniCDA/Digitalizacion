using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalizacion.v1.Core.Entity
{
    public class Contratista
    {
        public int IdContratista { get; set; }
        public string Cuil { get; set; }

        public Contratista()
        {
        }

        public Contratista(int idContratista, string cuil)
        {
            IdContratista = idContratista;
            Cuil = cuil;
        }
    }
}
