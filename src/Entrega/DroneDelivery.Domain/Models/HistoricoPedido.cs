﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DroneDelivery.Domain.Models
{
    public class HistoricoPedido
    {

        public Guid Id { get; private set; }

        public Guid DroneId { get; private set; }
        public Drone Drone { get; }

        public Guid PedidoId { get; private set; }
        public Pedido Pedido { get; }

        public DateTime DataSaida { get; private set; }
        public DateTime? DataEntrega { get; private set; }

        protected HistoricoPedido()
        {

        }

        private HistoricoPedido(Guid droneId, Guid pedidoId)
        {
            Id = Guid.NewGuid();
            DroneId = droneId;
            PedidoId = pedidoId;
            DataSaida = DateTime.Now;
        }

        public static HistoricoPedido Criar(Guid droneId, Guid pedidoId)
        {
            return new HistoricoPedido(droneId, pedidoId);
        }

        public void MarcarEntregaCompleta()
        {
            DataEntrega = DateTime.Now;
        }
    }
}
