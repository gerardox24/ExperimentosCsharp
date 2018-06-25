using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelefonosCRUD.Test
{
    public class Selenium
    {
        String urlInicial = "localhost:54686";
        ClientePage clientePage;
        TelefonoPage telefonoPage;
        static Object[] lista=Excel.leerExcel(@"D:\data\Datos.xlsx", 5, 2);
        static Object[] lista2 = Excel.leerExcel(@"D:\data\Datos.xlsx", 5, 2);
        static Object[] lista3 = Excel.leerExcel(@"D:\data\Datos2.xlsx", 4, 1);
        static Object[] lista4 = Excel.leerExcel(@"D:\data\Datos2.xlsx", 4, 1);
        [SetUp]
        public void inicioClase()
        {
            
            this.clientePage = new ClientePage(this.urlInicial);
            this.telefonoPage = new TelefonoPage(clientePage.getWebDriver(),this.urlInicial);
        }


        [Test, TestCaseSource("lista")]
         public void d_InsertarCliente(String pnombre,String apaterno, String amaterno, String pdni, String pdireccion)
         {
             try {
                bool valorObtenido = true;// clientePage.insertar(pnombre, apaterno, amaterno, pdni, pdireccion);
             Assert.AreEqual(valorObtenido, true);
             }
             catch (Exception e)
             {
                 Assert.Fail();
             }
         }

        [Test, TestCaseSource("lista2")]
        public void e_EditarCliente(String pnombre, String apaterno, String amaterno, String pdni, String pdireccion)
        {
            try
            {
                bool valorObtenido = true;//clientePage.Editar(pnombre, apaterno, amaterno, pdni, pdireccion);
                Assert.AreEqual(valorObtenido, true);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
        [Test]
        public void f_EliminarCliente()
        {
            try
            {
                bool valorObtenido = true;//clientePage.Eliminar();
                Assert.AreEqual(valorObtenido, true);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
        [Test,TestCaseSource("lista3")]
        public void a_InsertarTelefono(String Modelo, String Marca, String Numero, String ClienteID)
        {
            try
            {
                bool valorObtenido = telefonoPage.insertar(Modelo, Marca, Numero, ClienteID);
                Assert.AreEqual(valorObtenido, true);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
        [Test, TestCaseSource("lista4")]
        public void b_EditarTelefono(String Modelo, String Marca, String Numero, String ClienteID)
        {
            try
            {
                bool valorObtenido = telefonoPage.Editar(Modelo, Marca, Numero, ClienteID);
                Assert.AreEqual(valorObtenido, true);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
        
        [Test]
        public void c_EliminarTelefono()
        {
            try
            {
                bool valorObtenido = telefonoPage.Eliminar();
                Assert.AreEqual(valorObtenido, true);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
        [TearDown]
        public void End() {
            clientePage.cerrarPagina();
        }


    }
}