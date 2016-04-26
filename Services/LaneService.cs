using System;
using System.Collections.Generic;
using System.Linq;
using FreightAppASP.DataContexts;
using FreightAppASP.Models;
using FreightAppASP.ViewModels;
using Microsoft.Data.Entity;

namespace FreightAppASP.Services
{
    public class LaneService : IDisposable
    {
        private CarrierContext entities;

        public LaneService(CarrierContext entities)
        {
            this.entities = entities;
        }

        public IEnumerable<LaneViewModel> Read()
        {
            return entities.Lanes.Select(lane => new LaneViewModel
            {
                LaneId = lane.LaneId,
                CarrierId = lane.CarrierId,
                OriginCity = lane.OriginCity,
                DestinationCity = lane.DestinationCity,
                Radius = lane.Radius
            });
        }
        public void Create(LaneViewModel product)
        {
            var entity = new Lanes();

            entity.OriginCity = product.OriginCity;

            entities.Lanes.Add(entity);
            entities.SaveChanges();

            product.CarrierId = entity.CarrierId;
        }

        public void Dispose()
        {
            entities.Dispose();
        }
    }
}
   