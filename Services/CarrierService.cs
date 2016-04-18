using System;
using System.Collections.Generic;
using System.Linq;
using FreightAppASP.DataContexts;
using FreightAppASP.Models;
using FreightAppASP.ViewModels;
using Microsoft.AspNet.Http;
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
                CarrierId = carrier.CarrierId,
                PhysicalCity = carrier.PhysicalCity,
                PhysicalState = carrier.PhysicalState,
                PhysicalZip = carrier.PhysicalZip,
                PrimaryContactName = carrier.PrimaryContactName,
                PhysicalAddress = carrier.PhysicalAddress,          
                DotNumber = carrier.DotNumber,
                IsTaxtId = carrier.IsTaxtId,
                DbaName = carrier.DbaName,
                MailingAddress = carrier.MailingAddress,
                MailingCity = carrier.MailingCity,
                MailingState = carrier.MailingState,
                MailingZip = carrier.MailingZip,
                Phone = carrier.Phone,
                Fax = carrier.Fax,
                PrimaryContactPhone = carrier.PrimaryContactPhone,
                PrimaryContactEmail = carrier.PrimaryContactEmail,
                DispatchContactName = carrier.DispatchContactName,
                DispatchContactPhone = carrier.DispatchContactPhone,
                DispatchContactEmail = carrier.DispatchContactEmail,
                AccountingContactName = carrier.AccountingContactName,
                AccountingContactPhone = carrier.AccountingContactPhone,
                AccountingContactEmail = carrier.AccountingContactEmail
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

        public void ImportCarriers(IEnumerable<IFormFile> files)
        {
            
        }
    }
}