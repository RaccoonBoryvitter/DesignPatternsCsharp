using Proxy.Enums;
using Proxy.IServices;
using Proxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proxy.Services
{
    internal class CargoTransportServiceProxy : ICargoTransportService
    {
        public List<CargoTransport> Cache { get; set; }

        public ManagerPermissions AuthLevel { get; set; }

        public LoggerService Logger { get; set; }

        public CargoTransportService Service { get; set; }

        public CargoTransportServiceProxy(
            CargoTransportService service, 
            LoggerService logger,
            ManagerPermissions authLevel)
        {
            Service = service;
            Logger = logger;
            AuthLevel = authLevel;
        }

        public List<CargoTransport> All()
        {
            if (AuthLevel == ManagerPermissions.ReadWrite
                || AuthLevel == ManagerPermissions.ReadWriteUpdateDelete)
            {
                if (Cache == null)
                    Cache = Service.All();

                Logger.LogInfo("Getting all info from Transports");
                return Cache;
            }
            else
            {
                Logger.LogDanger("WARNING! Unathorized access has been detected!");
                return null;
            }
        }

        public void Delete(CargoTransport cargoTransport)
        {
            if(AuthLevel == ManagerPermissions.ReadWriteUpdateDelete)
            {
                Logger.LogInfo($"Deleting a record #{cargoTransport.Id} from database...");
                Service.Delete(cargoTransport);
                Logger.LogInfo($"The record has been deleted successfully!");
            }
            else
            {
                Logger.LogDanger("WARNING! Unathorized access has been detected!");
                return;
            }
        }

        public CargoTransport GetById(Guid id)
        {
            if (AuthLevel == ManagerPermissions.ReadWrite 
                || AuthLevel == ManagerPermissions.ReadWriteUpdateDelete)
            {
                Logger.LogInfo($"Retreiving a record #{id} from database...");
                
                CargoTransport result;
                if (Cache != null)
                    result = Cache.FirstOrDefault(t => t.Id == id);
                else
                    result = Service.GetById(id);

                Console.WriteLine(result);
                Logger.LogInfo($"The record has been retreived successfully!");
                return result;
            }
            else
            {
                Logger.LogDanger("WARNING! Unathorized access has been detected!");
                return null;
            }
        }

        public void Insert(CargoTransport cargoTransport)
        {
            if (AuthLevel == ManagerPermissions.ReadWrite
                || AuthLevel == ManagerPermissions.ReadWriteUpdateDelete)
            {
                Logger.LogInfo($"Inserting a new record into a database...");
                Service.Insert(cargoTransport);
                Logger.LogInfo($"The record has been retreived successfully!");
            }
            else
            {
                Logger.LogDanger("WARNING! Unathorized access has been detected!");
                return;
            }
        }

        public void Update(CargoTransport cargoTransport)
        {
            if (AuthLevel == ManagerPermissions.ReadWriteUpdateDelete)
            {
                Logger.LogInfo($"Updating a record #{cargoTransport.Id} into a database...");
                Service.Update(cargoTransport);
                Logger.LogInfo($"The record has been updated successfully!");
            }
            else
            {
                Logger.LogDanger("WARNING! Unathorized access has been detected!");
                return;
            }
        }
    }
}
