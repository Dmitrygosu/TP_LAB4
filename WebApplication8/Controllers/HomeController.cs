using System;
using System.Web.Mvc;

[HandleError]
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
  

    public ActionResult Index0(string uvar = "Пользовательская переменная не задана")
    {
        ViewBag.MyIndex0 = uvar;
        return View();
    }


}
