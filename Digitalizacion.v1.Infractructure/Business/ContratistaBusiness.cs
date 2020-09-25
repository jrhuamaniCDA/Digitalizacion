using Digitalizacion.v1.Core.Entity;
using Digitalizacion.v1.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace Digitalizacion.v1.Infractructure.Business
{
    public class ContratistaBusiness : IContratistaBusiness
    {
        private readonly IContratistasServices _contratistasServices;

        public ContratistaBusiness(IContratistasServices contratistasServices)
        {
            _contratistasServices = contratistasServices;
        }
        public List<Contratista> ObtenerTodos()
        {
            return _contratistasServices.ObtenerTodos();
        }
    }
}
