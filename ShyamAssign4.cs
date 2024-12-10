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
public class TestAssignTest {
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
  public void insuranceQuote01() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.CssSelector(".container")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("24");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$5500"));
    }
  }
  [Test]
  public void insuranceQuote02() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.CssSelector(".card:nth-child(1) > div > .form-group:nth-child(1)")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("25");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("4");
    driver.FindElement(By.CssSelector("body")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
    }
  }
  [Test]
  public void insuranceQuote03() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("35");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("9");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("2");
    driver.FindElement(By.CssSelector("body")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$3905"));
    }
  }
  [Test]
  public void insuranceQuote04() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.CssSelector(".container")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".container"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    driver.FindElement(By.Id("phone")).SendKeys("76777");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("27");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
  }
  [Test]
  public void insuranceQuote05() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.CssSelector(".card:nth-child(1) > div:nth-child(2)")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    {
      var element = driver.FindElement(By.Id("phone"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    {
      var element = driver.FindElement(By.Id("phone"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.Id("phone"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    driver.FindElement(By.CssSelector(".form-row:nth-child(5)")).Click();
    driver.FindElement(By.Id("email")).SendKeys("shyam.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("28");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
  }
  [Test]
  public void insuranceQuote06() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("35");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("15");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("1");
    driver.FindElement(By.CssSelector(".container")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    driver.FindElement(By.CssSelector(".form-row:nth-child(4)")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("245");
    driver.FindElement(By.Id("btnSubmit")).Click();
    Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
  }
  [Test]
  public void insuranceQuote07() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.CssSelector("body")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("5");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));
  }
  [Test]
  public void insuranceQuote08() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.CssSelector(".container")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("37");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("8");
    driver.FindElement(By.Id("btnSubmit")).Click();
    Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
  }
  [Test]
  public void insuranceQuote09() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.CssSelector("body")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.CssSelector(".card-body")).Click();
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("45");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));
  }
  [Test]
  public void insuranceQuote10() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.CssSelector("body")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("18");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("1");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$5500"));
    }
  }
  [Test]
  public void insuranceQuote11() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.CssSelector("body")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("17");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).Click();
    {
      var element = driver.FindElement(By.Id("experience"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("1");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("No Insurance for you!! Driver Age / Experience Not Correct"));
    }
  }
  [Test]
  public void insuranceQuote12() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.CssSelector("body")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("24");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("2");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$5500"));
    }
  }
  [Test]
  public void insuranceQuote13() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.CssSelector("body")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("30");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("12");
    driver.FindElement(By.Id("accidents")).SendKeys("15");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
    }
  }
  [Test]
  public void insuranceQuote14() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.CssSelector("body")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("20");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("5");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("1");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("No Insurance for you!! Driver Age / Experience Not Correct"));
    }
  }
  [Test]
  public void insuranceQuote15() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("shyam");
    driver.FindElement(By.Id("lastName")).SendKeys("modi");
    driver.FindElement(By.Id("address")).SendKeys("38 Rauch ct");
    driver.FindElement(By.Id("city")).SendKeys("kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2N 3C7");
    driver.FindElement(By.Id("phone")).SendKeys("4376693218");
    driver.FindElement(By.Id("email")).SendKeys("shyammodi41@gmail.com");
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Shyam");
    driver.FindElement(By.CssSelector("body")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("437-669-3218");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("100");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("80");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("1");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$2840"));
    }
  }
}
