using OpenQA.Selenium;

namespace PageObjectTest.Pages
{
    public class CustomerPortalLogin(IWebDriver driver)
    {
        private string usernameXpath = "//*[@id=\"UserName\"]";
        private string passwordXpath = "//*[@id=\"Password\"]";
        private string loginButtonXpath = "//*[@id=\"loginPanel\"]/div/div/div[2]/button";

        public void ClickLoginButton(string username, string login)
        {
            var usernameField = driver.FindElement(By.XPath(usernameXpath));
            var passwordField = driver.FindElement(By.XPath(passwordXpath));
            var loginButton = driver.FindElement(By.XPath(loginButtonXpath));

            usernameField.SendKeys(username);
            passwordField.SendKeys(login);
            loginButton.Click();
        }
    }
}
