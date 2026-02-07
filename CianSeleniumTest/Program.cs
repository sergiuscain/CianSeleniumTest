using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static IWebDriver driver = new ChromeDriver();
    private static readonly By _signInButton = By.XPath("//span[text()='Войти']");
    private static readonly By _anotherWayButton = By.XPath("//span[text()='Другой способ']");
    private static readonly By _loginInput = By.XPath("//input[@name='username']");
    public static string loginText;
    public static void Main()
    {
        //Переходим на страницу Циана
        driver.Navigate().GoToUrl("https://cian.ru");
        //Делаем браузер на весь экран
        driver.Manage().Window.Maximize();
        //Выводим название страницы (для теста)
        Console.WriteLine($"{driver.Title}");

        //Находим кнопку "Войти"
        var signIn = driver.FindElement(_signInButton);
        signIn.Click();
        Console.WriteLine("Нажата кнопка 'Войти'");

        //Находим кнопку "Другой способ"
        var anotherWay = driver.FindElement(_anotherWayButton);
        anotherWay.Click();
        Console.WriteLine("Нажата кнопка 'Другой способ'");

        //Находим поля ввода и вводим в него loginText
        var loginInput = driver.FindElement(_loginInput);
        Console.WriteLine("Введите логин");
        loginText = Console.ReadLine();
        loginInput.SendKeys(loginText);
        Console.WriteLine($"Введен логин: {loginText}");

    }
}