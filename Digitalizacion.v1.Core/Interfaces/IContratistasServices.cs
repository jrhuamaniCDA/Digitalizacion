using Digitalizacion.v1.Core.Entity;
using System.Collections.Generic;

namespace Digitalizacion.v1.Core.Interfaces
{
    public interface IContratistasServices
    {
        Contratista ObtenerContratista(string id);
        List<Contratista> ObtenerTodos();
    }
}
