using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace PageObjectTest.UnitTests;

public class Tests
{
    private IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new EdgeDriver();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Manage().Window.Maximize();
    }

    [Test]
    public void Test1()
    {
        driver.Navigate().GoToUrl("https://www.novarad.net/");
        var homePage = new HomePage(driver);
        var loginPage = homePage.ClickCustomerPortal();
        loginPage.ClickLoginButton("Login", "password");


    }

    [TearDown]

    public void TearDown()
    {
        driver.Quit();
        driver.Dispose();
    }
}