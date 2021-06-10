using ComplementoParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplementoParcial.Repository
{
    public interface IVentas
    {
        List<DiscosResponse> GetMostSold();
        List<DiscosResponse> GetMostSoldFiltered(DateTime desde,DateTime hasta);
    }
}
