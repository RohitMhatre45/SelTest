// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

Console.WriteLine("Hello, World!");

IWebDriver driver=  new ChromeDriver(@"D:\drv\cdac");
IJavaScriptExecutor js = (IJavaScriptExecutor)driver; 
IDictionary<String, Object>  vars = new Dictionary<String, Object>();

driver.Navigate().GoToUrl("http://localhost:8000/");
driver.Manage().Window.Size = new System.Drawing.Size(1366, 535);
driver.FindElement(By.LinkText("Gallery")).Click();
driver.FindElement(By.Id("1")).Click();
driver.FindElement(By.CssSelector("button")).Click();
driver.FindElement(By.CssSelector("tr:nth-child(1)")).Click();
driver.FindElement(By.CssSelector("tr:nth-child(2)")).Click();
driver.FindElement(By.Id("txtquantity")).SendKeys("23");
driver.FindElement(By.CssSelector("td:nth-child(1) > input")).Click();
driver.FindElement(By.LinkText("Gallery")).Click();
driver.FindElement(By.Id("7")).Click();
driver.FindElement(By.CssSelector("button")).Click();
{
    var element = driver.FindElement(By.CssSelector("tr:nth-child(2) > td:nth-child(1)"));
    Actions builder = new Actions(driver);
    builder.MoveToElement(element).ClickAndHold().Perform();
}

{
    var element = driver.FindElement(By.CssSelector("tr:nth-child(2) > td:nth-child(1)"));

    Actions builder = new Actions(driver);
    builder.MoveToElement(element).Perform();
}

{
    var element = driver.FindElement(By.CssSelector("tr:nth-child(2) > td:nth-child(1)"));
    Actions builder = new Actions(driver);
    builder.MoveToElement(element).Release().Perform();
}

driver.FindElement(By.CssSelector("tr:nth-child(2)")).Click();
driver.FindElement(By.Id("txtquantity")).SendKeys("45");
driver.FindElement(By.CssSelector("td:nth-child(1) > input")).Click();
driver.FindElement(By.LinkText("Gallery")).Click();


