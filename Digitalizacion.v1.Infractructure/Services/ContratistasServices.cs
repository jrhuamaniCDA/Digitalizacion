using Digitalizacion.v1.Core.Entity;
using Digitalizacion.v1.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Digitalizacion.v1.Infractructure.Services
{
    public class ContratistasServices : IContratistasServices
    {
        public List<Contratista> lista { get; set; }

        public ContratistasServices()
        {
            lista = new List<Contratista>()
            {
                new Contratista(23,"987878437"),
                new Contratista(22,"938939943"),
                new Contratista(3,"37878437"),
                new Contratista(10,"587878437"),
            };
        }
        public List<Contratista> ObtenerTodos()
        {
            return lista;
        }
        public Contratista ObtenerContratista(string id)
        {
            return lista.FirstOrDefault(c => c.IdContratista.Equals(id));
        }
    }
}
