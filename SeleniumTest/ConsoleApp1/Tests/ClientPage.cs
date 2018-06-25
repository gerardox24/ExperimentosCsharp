using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace TelefonosCRUD.Test
{
    public class ClientePage
    {
        IWebDriver webDriver = null;
        By linkCliente = By.XPath("/html/body/div[2]/div[2]/div[1]/h2/a");
        By linkCreate = By.XPath("/html/body/div[2]/p/a");
        By linkEditar = By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[6]/a[1]");
        By linkEliminar = By.XPath("/html/body/div[2]/table/tbody/tr[4]/td[6]/a[3]");
        By txtNombre = By.Id("Nombre");
        By txtAPaterno = By.Id("ApellidoPaterno");
        By txtAMaterno = By.Id("ApellidoMaterno");
        By txtDNI = By.Id("DNI");
        By txtDireccion = By.Id("Direccion");
        By btnCreate = By.XPath("/html/body/div[2]/form/div/div[6]/div/input");
        By btnDelete = By.XPath("/html/body/div[2]/div/form/div/input");
        String Urlt = null;
        public ClientePage(String Url)
        {
            this.webDriver = Driver.inicializarDriver();
            this.Urlt = Url;

        }

        public bool insertar(String nombre, String apaterno, String amaterno, String DNI, String direccion)
        {
            webDriver.Navigate().GoToUrl(Urlt);
            webDriver.FindElement(linkCliente).Click();
            Thread.Sleep(3000);
            webDriver.FindElement(linkCreate).Click();
            Thread.Sleep(3000);
            webDriver.FindElement(txtNombre).Clear();
            webDriver.FindElement(txtNombre).SendKeys(nombre);
            webDriver.FindElement(txtAPaterno).Clear();
            webDriver.FindElement(txtAPaterno).SendKeys(apaterno);
            webDriver.FindElement(txtAMaterno).Clear();
            webDriver.FindElement(txtAMaterno).SendKeys(amaterno);
            webDriver.FindElement(txtDNI).Clear();
            webDriver.FindElement(txtDNI).SendKeys(DNI);
            webDriver.FindElement(txtDireccion).Clear();
            webDriver.FindElement(txtDireccion).SendKeys(direccion);
            webDriver.FindElement(btnCreate).Click();
            Thread.Sleep(3000);
            return true;
        }
        public bool Editar(String nombre, String apaterno, String amaterno, String DNI, String direccion)
        {
            webDriver.Navigate().GoToUrl(Urlt);
            webDriver.FindElement(linkCliente).Click();
            Thread.Sleep(3000);
            webDriver.FindElement(linkEditar).Click();
            Thread.Sleep(3000);
            webDriver.FindElement(txtNombre).Clear();
            webDriver.FindElement(txtNombre).SendKeys(nombre);
            webDriver.FindElement(txtAPaterno).Clear();
            webDriver.FindElement(txtAPaterno).SendKeys(apaterno);
            webDriver.FindElement(txtAMaterno).Clear();
            webDriver.FindElement(txtAMaterno).SendKeys(amaterno);
            webDriver.FindElement(txtDNI).Clear();
            webDriver.FindElement(txtDNI).SendKeys(DNI);
            webDriver.FindElement(txtDireccion).Clear();
            webDriver.FindElement(txtDireccion).SendKeys(direccion);
            webDriver.FindElement(btnCreate).Click();
            Thread.Sleep(3000);
            return true;
        }
        public bool Eliminar()
        {
            webDriver.Navigate().GoToUrl(Urlt);
            webDriver.FindElement(linkCliente).Click();
            Thread.Sleep(3000);
            webDriver.FindElement(linkEliminar).Click();
            Thread.Sleep(3000);
            webDriver.FindElement(btnDelete).Click();
            Thread.Sleep(3000);
            return true;
        }
        public void cerrarPagina()
        {
            Driver.cerrarPagina(webDriver);
        }
        public IWebDriver getWebDriver()
        {
            return webDriver;
        }

    }
}