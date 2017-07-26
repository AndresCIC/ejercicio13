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
        private EntradaDTO entradaDTO;

        [TestInitialize]
        public void Initialize()
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IEntradaRepository, EntradaRepository>();
            unityContainer.RegisterType<IEntradaService, EntradaService>();
            unityContainer.RegisterType<IEntradaConverter, EntradaConverter>();
            unityContainer.RegisterType<IEntradaController, EntradaController>();
            entradaController = unityContainer.Resolve<IEntradaController>();
            entradaDTO = new EntradaDTO();
            entradaDTO.Id = 5;
            entradaController.Create(entradaDTO);
        }


        [TestMethod]
        public void CreateMethodTest()
        {
            entradaController.Create(entradaDTO);    
            Assert.AreNotEqual(-1, entradaController.List().IndexOf(entradaDTO));
        }

        [TestMethod]
        public void ReadMethodTest()
        {
            Assert.IsNotNull(entradaController.Read(entradaDTO.Id));
        }

        [TestMethod]
        public void DeleteMethodTest()
        {
            entradaController.Delete(entradaDTO.Id);
            Assert.AreEqual(-1, entradaController.List().IndexOf(entradaDTO));
        }

        [TestMethod]
        public void ListMethodTest()
        {
            Assert.IsTrue(entradaController.List().Count > 0);
        }

        [TestMethod]
        public void UpdateMethodTest()
        {
            entradaDTO.Id = 6;
            entradaController.Update(entradaDTO);
            Assert.AreEqual(6, entradaController.Read(entradaDTO.Id).Id);


        }

    }
}
