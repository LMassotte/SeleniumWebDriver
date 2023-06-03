using Selenium.Utils;

string resultUrl = ScenariHelper.TryingToNavigateToChiefPageAsDataScientistScenario();
Console.WriteLine("If I connect as Data Scientist and try to navigate to Chief page, i'm redirected to : " + resultUrl);

resultUrl = ScenariHelper.TryingToNavigateToChiefPageAsChiefScenario();
Console.WriteLine("But if I'm connected as a Chief and navigate to Chief page, the url is : " + resultUrl);