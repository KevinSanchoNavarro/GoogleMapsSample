using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mapss.Models
{
    public class Punto
    {
        public double puntoX { get; set; }
        public double puntoY { get; set; }
        public int estadoId { get; set; }
        public string information { get; set; }

        public Punto(double x, double  y, int est, string info)
        {
            this.puntoX = x;
            this.puntoY = y;
            this.estadoId = est;
            this.information = info;
        }
    }
}