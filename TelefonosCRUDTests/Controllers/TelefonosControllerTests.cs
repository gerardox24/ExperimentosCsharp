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
    public class TelefonosControllerTests
    {
        [TestCase]
        public void createTelefono()
        {
            TelefonosController tc = new TelefonosController();
            var telefono = new Models.Telefonos();
            telefono.Marca = "Samsung";
            telefono.Modelo = "S8";
            telefono.Numero = 953991653;
            telefono.ClienteID = 1;

            ActionResult result = tc.Create(telefono);
            Assert.That(result, Is.InstanceOf<RedirectToRouteResult>());
        }

        [TestCase]
        public void editTelefono()
        {
            TelefonosController tc = new TelefonosController();
            var telefono = new Models.Telefonos();
            telefono.PhoneID = 3;
            telefono.Marca = "Apple";
            telefono.Modelo = "Iphone X";
            telefono.Numero = 999642138;
            telefono.ClienteID = 3;

            ActionResult result = tc.Edit(telefono);
            Assert.That(result, Is.InstanceOf<RedirectToRouteResult>());
        }

        [TestCase]
        public void deleteTelefono()
        {
            TelefonosController tc = new TelefonosController();
            var PhoneID = 3;

            ActionResult result = tc.Delete(PhoneID);
            Assert.That(result, Is.InstanceOf<ViewResult>());
        }
    }
}