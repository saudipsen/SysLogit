using SysLogit.Business.Contracts;
using SysLogit.Business.Services;
using SysLogit.Models;
using SysLogit.Repository.Contracts;
using SysLogit.Repository.Contracts.SysLogit.Repository.Contracts;
using SysLogit.Repository.Services;
using SysLogit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Storage;

namespace SysLogit.Unity
{
    public static class UnityConfig
    {
        public static UnityContainer RegisterComponents()
        {
            
            
            
            var container = new UnityContainer();

            // Register DbContext
            container.RegisterType<AppDbContext>();
            // Register DbContext
            container.RegisterType<AppDbContext>();

            //Register contracts
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IShipmentService, ShipmentService>();

            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IShipmentRepository, ShipmentRepository>();

            // Register forms
            container.RegisterType<ManageInventory>();
            container.RegisterType<ManageShipment>();
            container.RegisterType<Main>();

            var registrations = container.Registrations;
            foreach (var reg in registrations)
            {
                Console.WriteLine($"Registered: {reg.RegisteredType} to {reg.MappedToType}");
            }

            return container;
        }
    }
}
