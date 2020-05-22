using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // スラッシュ3つ　ドキュメント記法
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, int numTimes = 1)
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //return "This is the Welcome action method...";
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
            //ビューを参照させている
        }


        // GET: /HelloWorld/ohayou/ 
        //
        public string ohayou()
        {
            return "おはようメソッド";
            //localhost:44309/helloWorld/welcome?name=Mike&numtimes=3
            //名前と数値を指定→Hello Mike, NumTimes is: 3
            //何も指定しない場合→Hello , NumTimes is: 1　
        }
    }
}