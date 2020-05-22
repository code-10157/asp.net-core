using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Test2.Controllers
{
    public class BeginController : Controller
    {
        public IActionResult Index()
        {
        //    return Content("HEllo!!!!!!!!!World" + "Hey!!");
            return View();
        }
        public IActionResult Show()
        {
            ViewData["message"] = "ViewData[message]に入れた文字列が出力→コントローラーで定義。";
            ViewBag.message2 = "ViewBag.message2の変数→コントローラーで定義。";
            return View();
        }
    }
}