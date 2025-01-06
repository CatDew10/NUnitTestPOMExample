using OpenQA.Selenium;

namespace PageObjectTest.Pages;

public class HomePage(IWebDriver driver)
{
    private string customerPortalXPath = "//*[@id=\"hs_cos_wrapper_header_navigation_primary\"]/nav/ul/li[5]";

    public CustomerPortalLogin ClickCustomerPortal()
    {
        var customerPortalButton = driver.FindElement(By.XPath(customerPortalXPath));
        customerPortalButton.Click();
        return new CustomerPortalLogin(driver);
    }


}
