using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Web;

namespace PrototipoTCC
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonTesteRegistro_Click(object sender, EventArgs e)
        {
            IWebDriver driver = startBrowser();
            driver.Url = HttpContext.Current.Request.Url.Authority + "/Registro";
            //    "localhost:62342/Registro";
            
            testeCampoNomeRegistro(driver);
            cleanRegistro(driver);
            testeCampoEmailRegistro(driver);
            cleanRegistro(driver);
            testeCampoCpfRegistro(driver);
            cleanRegistro(driver);
            testeCampoSenha(driver);
            cleanRegistro(driver);
            testeCampoSenhaConfirma(driver);
            cleanRegistro(driver);
            testeCampoIdade(driver);
            cleanRegistro(driver);
            testeRegistroOk(driver);

        }
        
        

        private void testeRegistroOk(IWebDriver driver)
        {
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).SendKeys("1234567890");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).SendKeys("teste123");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenhaConfirma")).SendKeys("teste123");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxIdade")).SendKeys("25");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
        }

        private void waitMiliSegundos(int v)
        {
            System.Threading.Thread.Sleep(v);
        }

        private void testeCampoIdade(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).SendKeys("1234567890");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).SendKeys("teste123");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenhaConfirma")).SendKeys("teste123");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxIdade")).SendKeys("teste");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
        }

        private void testeCampoSenhaConfirma(IWebDriver driver)
        {
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).SendKeys("1234567890");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).SendKeys("teste123");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenhaConfirma")).SendKeys("teste");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
        }

        private void testeCampoSenha(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).SendKeys("1234567890");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).SendKeys("teste");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
            cleanRegistro(driver);
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).SendKeys("1234567890");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).SendKeys("12345");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
        }

        private void testeCampoCpfRegistro(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).SendKeys("teste");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
        }

        private void testeCampoEmailRegistro(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
        }

        private void cleanRegistro(IWebDriver driver)
        {
            waitMiliSegundos(300);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).Clear();
            waitMiliSegundos(300);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).Clear();
            waitMiliSegundos(300);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).Clear();
            waitMiliSegundos(300);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).Clear();
            waitMiliSegundos(300);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenhaConfirma")).Clear();
            waitMiliSegundos(300);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxIdade")).Clear();
            waitMiliSegundos(1000);
        }

        private void testeCampoNomeRegistro(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("teste1");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
        }

        protected void ButtonTesteLogin_Click(object sender, EventArgs e)
        {
            IWebDriver driver = startBrowser();
            driver.Url = driver.Url = HttpContext.Current.Request.Url.Authority + "/Login";
            //"localhost:62342/Login";

            testeCampoEmailLogin(driver);
            cleanLogin(driver);
            testeCampoSenhaLogin(driver);
            cleanLogin(driver);
            testeLogin(driver);

        }

        private void testeLogin(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).SendKeys("teste123");
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonLogin")).Click();
            waitMiliSegundos(1000);
        }

        private void cleanLogin(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).Clear();
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).Clear();
            waitMiliSegundos(1000);
        }

        private void testeCampoSenhaLogin(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).SendKeys("teste");
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonLogin")).Click();
            waitMiliSegundos(1000);
        }

        private void testeCampoEmailLogin(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste");
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).SendKeys("teste");
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonLogin")).Click();
            waitMiliSegundos(1000);
        }

        public ChromeDriver startBrowser()
        {
            if (Environment.OSVersion.ToString().Contains("Mac") || Environment.OSVersion.ToString().Contains("Apple") || !Environment.OSVersion.ToString().Contains("Windows") || 
                Environment.OSVersion.ToString().Contains("MacOS") || Environment.OSVersion.ToString().Contains("mac") 
                || Environment.OSVersion.ToString().Contains("macos"))
            {
                return new ChromeDriver("C:\\Users\\PICHAU\\source\\repos\\PrototipoTCC\\PrototipoTCC\\drivermac");
            }
            return new ChromeDriver("C:\\Users\\PICHAU\\source\\repos\\PrototipoTCC\\PrototipoTCC\\");
            

        }
        public void close(IWebDriver driver)
        {
            driver.Close();
        }
    }
}