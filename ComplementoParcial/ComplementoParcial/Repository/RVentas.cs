using ComplementoParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace ComplementoParcial.Repository
{
    public class RVentas : IVentas
    {
        private readonly Model1 db = new Model1();
        public List<DiscosResponse> GetMostSold()
        {
            var items = db.DetallePedido.Include(d=>d.discos).ToList();
            List<DiscosResponse> MostSold = items
                .GroupBy(d => d.iddiscos)
                .Select(discos => new DiscosResponse
                {
                    Titulo = discos.First().discos.titulo,
                    Cantidad = discos.Sum(s => s.cantidad),
                    Monto = discos.Sum(s => s.precioVenta * s.cantidad)
                })
                .OrderByDescending(d => d.Monto)
                .Take(3).ToList();
            return MostSold;
        }

        public List<DiscosResponse> GetMostSoldFiltered(DateTime desde, DateTime hasta)
        {
            var items = db.DetallePedido.Include(d => d.discos).Include(d=>d.Pedido).ToList();
            List<DiscosResponse> MostSold = items
                .Where(ped=>ped.Pedido.fechaPedido>desde && ped.Pedido.fechaPedido<hasta)
                .GroupBy(d => d.iddiscos)
                .Select(discos => new DiscosResponse
                {
                    Titulo = discos.First().discos.titulo,
                    Cantidad = discos.Sum(s => s.cantidad),
                    Monto = discos.Sum(s => s.precioVenta * s.cantidad)
                })
                .OrderByDescending(d => d.Monto)
                .Take(3).ToList();
            return MostSold;
        }
    }
}