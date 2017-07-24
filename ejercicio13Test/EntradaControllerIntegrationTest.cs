using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio13.Entrada;
using Microsoft.Practices.Unity;

namespace ejercicio13Test
{
    [TestClass]
    public class EntradaControllerIntegrationTest
    {
        private IEntradaController entradaController;

        [TestInitialize]
        public void Initialize()
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IEntradaRepository, EntradaRepository>();
            unityContainer.RegisterType<IEntradaService, EntradaService>();
            unityContainer.RegisterType<IEntradaConverter, EntradaConverter>();

            unityContainer.RegisterType<IEntradaController, EntradaController>();


            entradaController = unityContainer.Resolve<IEntradaController>();
        }


        [TestMethod]
        public void CreateMethodTest()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Create(entradaDTO);
        }

        [TestMethod]
        public void ReadMethodTest()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaDTO.Id = 1;
            entradaController.Read(entradaDTO.Id);
        }

    }
}
