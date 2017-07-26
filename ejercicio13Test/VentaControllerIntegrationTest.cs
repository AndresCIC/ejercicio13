using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio13;
using Microsoft.Practices.Unity;

namespace ejercicio13Test
{
    [TestClass]
    public class VentaControllerIntegrationTest
    {
        private IVentaController ventaController;
        
        [TestInitialize]
        public void Init()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IVentaController, VentaController>();
            container.RegisterType<IVentaService, VentaService>();
            container.RegisterType<IVentaConverter, VentaConverter>();
            container.RegisterType<IVentaRepository, VentaRepository>();

            ventaController = container.Resolve<IVentaController>();
        }

        [TestMethod]
        public void CreateMethodTest()
        {
            VentaDTO ventaDTO = new VentaDTO();
            ventaController.Create(ventaDTO);

        }
    }
}
