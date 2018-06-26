using NUnit.Framework;
using TelefonosCRUD.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TelefonosCRUD.Controllers.Tests
{
    [TestFixture()]
    public class ClientesControllerTests
    {
        [TestCase]
        public void createCliente()
        {
            ClientesController tc = new ClientesController();
            var cliente = new Models.Cliente();
            cliente.Nombre = "Raphael";
            cliente.ApellidoPaterno = "Bravo";
            cliente.ApellidoMaterno = "Dedo";
            cliente.Direccion = "Jr Tacna 298";
            cliente.DNI = 72721896;

            ActionResult result = tc.Create(cliente);
            Assert.That(result, Is.InstanceOf<RedirectToRouteResult>());
        }

        [TestCase]
        public void editCliente()
        {
            ClientesController tc = new ClientesController();
            var cliente = new Models.Cliente();
            cliente.ClienteID = 4;
            cliente.Nombre = "Pieter";
            cliente.ApellidoPaterno = "Gleixner";
            cliente.ApellidoMaterno = "Rodrigues";
            cliente.Direccion = "Donde sea 348";
            cliente.DNI = 79846532;

            ActionResult result = tc.Edit(cliente);
            Assert.That(result, Is.InstanceOf<RedirectToRouteResult>());
        }

        [TestCase]
        public void deleteCliente()
        {
            ClientesController tc = new ClientesController();
            var ClienteID = 4;

            ActionResult result = tc.Delete(ClienteID);
            Assert.That(result, Is.InstanceOf<ViewResult>());
        }
    }
}