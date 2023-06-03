using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using Selenium.Utils;

string resultUrl = ScenariHelper.TryingToNavigateToChiefPageAsDataScientistScenario();
Console.WriteLine("If I connect as Data Scientist and try to navigate to Chief page, i'm redirect to : " + resultUrl);

resultUrl = ScenariHelper.TryingToNavigateToChiefPageAsChiefScenario();
Console.WriteLine("But if I'm connected as a Chief and navigate to Chief page, the url is : " + resultUrl);