using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComplementoParcial.Models
{
    public class DiscosResponse
    {
        public string Titulo { get; set; }
        public int? Cantidad { get; set; }
        public double? Monto { get; set; }
       
    }
    public class DiscosLimitResponse
    {
        public DateTime desde { get; set; }
        public DateTime hasta { get; set; }
        public List<DiscosResponse> discos { get; set; }
    }
}