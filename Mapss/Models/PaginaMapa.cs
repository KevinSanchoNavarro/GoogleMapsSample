using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mapss.Models
{
    public class PaginaMapa
    {
        public int estadoId { get; set; }
        public List<Punto> puntos;


        public PaginaMapa() {
            puntos = new List<Punto>();
        }
    }
}