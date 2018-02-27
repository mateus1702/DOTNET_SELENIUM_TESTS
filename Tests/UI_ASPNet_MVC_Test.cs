using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
    [TestClass]
    public class UI_ASPNet_MVC_Test
    {
        private static Random RandomGenerator = new Random();

        private static string siteURL = "http://localhost:55388/";

        [TestMethod]
        public void CreateUser()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(siteURL);

                driver.FindElement(By.LinkText("Usuarios")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Cadastrar")).Displayed);

                driver.FindElement(By.LinkText("Cadastrar")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.Id("Name")).Displayed);

                driver.FindElement(By.Id("Name")).SendKeys("User Name");

                driver.FindElement(By.Id("Name")).Submit();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Cadastrar")).Displayed);
            }
        }

        [TestMethod]
        public void ReadUser()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(siteURL);

                driver.FindElement(By.LinkText("Usuarios")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Visualizar")).Displayed);

                driver.FindElement(By.LinkText("Visualizar")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Editar")).Displayed);
            }
        }

        [TestMethod]
        public void UpdateUser()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(siteURL);

                driver.FindElement(By.LinkText("Usuarios")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Editar")).Displayed);

                driver.FindElement(By.LinkText("Editar")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.Id("Name")).Displayed);


                driver.FindElement(By.Id("Name")).SendKeys($"User Name {RandomGenerator.Next(99)}");

                driver.FindElement(By.Id("Name")).Submit();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Editar")).Displayed);
            }
        }

        [TestMethod]
        public void DeleteUser()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(siteURL);

                driver.FindElement(By.LinkText("Usuarios")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Deletar")).Displayed);

                driver.FindElement(By.LinkText("Deletar")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Voltar a listagem")).Displayed);

                driver.FindElement(By.ClassName("btn")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Cadastrar")).Displayed);
            }
        }


        [TestMethod]
        public void CreateTask()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(siteURL);

                driver.FindElement(By.LinkText("Usuarios")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Tarefas")).Displayed);

                driver.FindElement(By.LinkText("Tarefas")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
               Until(x => x.FindElement(By.LinkText("Cadastrar")).Displayed);

                driver.FindElement(By.LinkText("Cadastrar")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.Id("Name")).Displayed);

                driver.FindElement(By.Id("Name")).SendKeys("Task Name");

                driver.FindElement(By.Id("Date")).SendKeys("17/02/1988");

                driver.FindElement(By.Id("Done")).Click();

                driver.FindElement(By.Id("Name")).Submit();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Cadastrar")).Displayed);
            }
        }

        [TestMethod]
        public void ReadTask()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(siteURL);

                driver.FindElement(By.LinkText("Usuarios")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Tarefas")).Displayed);

                driver.FindElement(By.LinkText("Tarefas")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
               Until(x => x.FindElement(By.LinkText("Visualizar")).Displayed);

                driver.FindElement(By.LinkText("Visualizar")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Voltar a listagem")).Displayed);
            }
        }


        [TestMethod]
        public void UpdateTask()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(siteURL);

                driver.FindElement(By.LinkText("Usuarios")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Tarefas")).Displayed);

                driver.FindElement(By.LinkText("Tarefas")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
               Until(x => x.FindElement(By.LinkText("Editar")).Displayed);

                driver.FindElement(By.LinkText("Editar")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.Id("Name")).Displayed);

                driver.FindElement(By.Id("Name")).Clear();
                driver.FindElement(By.Id("Name")).SendKeys($"Task Name {RandomGenerator.Next(99)}");

                driver.FindElement(By.Id("Date")).SendKeys($"17/02/{1988 + RandomGenerator.Next(99)}");

                driver.FindElement(By.Id("Done")).Click();

                driver.FindElement(By.Id("Name")).Submit();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Cadastrar")).Displayed);
            }
        }

        [TestMethod]
        public void DeleteTask()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(siteURL);

                driver.FindElement(By.LinkText("Usuarios")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Tarefas")).Displayed);

                driver.FindElement(By.LinkText("Tarefas")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Deletar")).Displayed);

                driver.FindElement(By.LinkText("Deletar")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Voltar a listagem")).Displayed);

                driver.FindElement(By.ClassName("btn")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Cadastrar")).Displayed);
            }
        }
    }
}
