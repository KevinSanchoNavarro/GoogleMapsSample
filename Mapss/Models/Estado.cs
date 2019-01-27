using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mapss.Models
{
    public class Estado
    {
        public int estadoId { get; set; }
        public string estadoDesc { get; set; }


        public Estado(int estadoId, string estadoDesc) {
            this.estadoId = estadoId;
            this.estadoDesc = estadoDesc;
        }
    }
}