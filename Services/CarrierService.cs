using System;
using System.Collections.Generic;
using System.Linq;
using FreightAppASP.DataContexts;
using FreightAppASP.Models;
using FreightAppASP.ViewModels;
using Microsoft.Data.Entity;

namespace FreightAppASP.Services
{
    public class CarrierService : IDisposable
    {
        private CarrierContext entities;

        public CarrierService(CarrierContext entities)
        {
            this.entities = entities;
        }

        public IEnumerable<CarrierViewModel> Read()
        {
            return entities.Carriers.Select(carrier => new CarrierViewModel
            {
                CompanyName = carrier.CompanyName,
                CarrierId = carrier.CarrierId
            });
        }

        public void Create(CarrierViewModel product)
        {
            var entity = new Carrier();

            entity.CompanyName = product.CompanyName;

            entities.Carriers.Add(entity);
            entities.SaveChanges();

            product.CarrierId = entity.CarrierId;
        }

        public void Dispose()
        {
            entities.Dispose();
        }
    }
}