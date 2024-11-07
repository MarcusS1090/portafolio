using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using portafolio.Models;


namespace portafolio.services
{
    public class RepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos() {
            return new List<ProyectoDTO>() { 
                new ProyectoDTO
                {
                    Titulo= "Bancolombia",
                    Descripcion= "Trabajando en el sector sucursal virtual personas",
                    Link= "https://www.bancolombia.com/personas",
                    ImgUrl = "/img/bancolombia.png"
                },
                new ProyectoDTO
                {
                    Titulo= "Sii x Salesforce",
                    Descripcion= "Trabajando en cloud de ventas con node.js y AWS",
                    Link= "https://sii.pl/en/what-we-offer/enterprise-platforms/salesforce/",
                    ImgUrl = "/img/salesforce.png"
                },
                new ProyectoDTO
                {
                    Titulo= "Amazon",
                    Descripcion= "E-Commerce realizado en ASP.NET Core",
                    Link= "https://amazon.com",
                    ImgUrl = "/img/amazon.png"
                },
            };
        } 
    }
}