using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace TelefonosCRUD.Test
{
    public class TelefonoPage
    {
        IWebDriver webDriver = null;
        By linkTelefonos = By.XPath("/html/body/div[2]/div[2]/div[2]/h2/a");
        By linkCreate = By.XPath("/html/body/div[2]/p/a");
        By linkEditar = By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[5]/a[1]");
        By linkEliminar = By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[5]/a[3]");
        By txtModelo = By.Id("Modelo");
        By txtMarca = By.Id("Marca");
        By txtNumero = By.Id("Numero");
        By txtClienteID = By.Id("ClienteID");
        By btnCreate = By.XPath("/html/body/div[2]/form/div/div[5]/div/input");
        By btnDelete = By.XPath("/html/body/div[2]/div/form/div/input");
        String Urlt = null;
        public TelefonoPage(IWebDriver wbd, String Url)
        {
            this.webDriver = wbd;
            Urlt = Url;
        }
        public bool insertar(String Modelo, String Marca, String Numero, String ClienteID)
        {
            webDriver.Navigate().GoToUrl(Urlt);
            webDriver.FindElement(linkTelefonos).Click();
            Thread.Sleep(3000);
            webDriver.FindElement(linkCreate).Click();
            Thread.Sleep(3000);
            webDriver.FindElement(txtModelo).Clear();
            webDriver.FindElement(txtModelo).SendKeys(Modelo);
            webDriver.FindElement(txtMarca).Clear();
            webDriver.FindElement(txtMarca).SendKeys(Marca);
            webDriver.FindElement(txtNumero).Clear();
            webDriver.FindElement(txtNumero).SendKeys(Numero);
            webDriver.FindElement(txtClienteID).Click();
            Thread.Sleep(3000);
            webDriver.FindElement(btnCreate).Click();
            Thread.Sleep(3000);
            return true;
        }
        public bool Editar(String Modelo, String Marca, String Numero, String ClienteID)
        {
            webDriver.Navigate().GoToUrl(Urlt);
            webDriver.FindElement(linkTelefonos).Click();
            Thread.Sleep(3000);
            webDriver.FindElement(linkEditar).Click();
            Thread.Sleep(3000);
            webDriver.FindElement(txtModelo).Clear();
            webDriver.FindElement(txtModelo).SendKeys(Modelo);
            webDriver.FindElement(txtMarca).Clear();
            webDriver.FindElement(txtMarca).SendKeys(Marca);
            webDriver.FindElement(txtNumero).Clear();
            webDriver.FindElement(txtNumero).SendKeys(Numero);
            webDriver.FindElement(txtClienteID).Click();
            Thread.Sleep(3000);
            webDriver.FindElement(btnCreate).Click();
            Thread.Sleep(3000);
            return true;
        }
        public bool Eliminar()
        {
            webDriver.Navigate().GoToUrl(Urlt);
            webDriver.FindElement(linkTelefonos).Click();
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