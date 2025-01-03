using SysLogit.Business.Contracts;
using SysLogit.Business.Services;
using SysLogit.Models;
using SysLogit.Repository.Contracts;
using SysLogit.Repository.Contracts.SysLogit.Repository.Contracts;
using SysLogit.Repository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace SysLogit.Unity
{
    public static class UnityConfig
    {
        public static UnityContainer RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IRepository<Product>, ProductRepository>();
            container.RegisterType<IRepository<Shipment>, ShipmentRepository>();

            return container;
        }
    }
}
