using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonosCRUD.Controllers;
using TelefonosCRUD.Models;
using TelefonosCRUD;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
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
            telefono.ClienteID = 2;

            ActionResult result = tc.Edit(telefono);
            Assert.That(result, Is.InstanceOf<RedirectToRouteResult>());
        }

        [TestCase]
        public void deleteTelefono()
        {
            TelefonosController tc = new TelefonosController();
            var PhoneID = 2;

            ActionResult result = tc.Delete(PhoneID);
            Assert.That(result, Is.InstanceOf<ViewResult>());
        }
    }
}
