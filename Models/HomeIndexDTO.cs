using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portafolio.Models
{
    public class HomeIndexDTO
    {
        public IEnumerable<ProyectoDTO> proyectos  { get; set; }
    }
}