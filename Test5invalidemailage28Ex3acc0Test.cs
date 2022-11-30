// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class Test5invalidemailage28Ex3acc0Test {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void test5invalidemailage28Ex3acc0() {
    driver.Navigate().GoToUrl("http://localhost/qa/index.html");
    driver.Manage().Window.Size = new System.Drawing.Size(981, 818);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Pallavi");
    driver.FindElement(By.Id("lastName")).SendKeys("Pallavi");
    driver.FindElement(By.Id("address")).Click();
    driver.FindElement(By.Id("address")).SendKeys("300 Regina ST W");
    driver.FindElement(By.Id("city")).Click();
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("548-333-7407");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("pallavirehan98");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("27");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
  }
}
