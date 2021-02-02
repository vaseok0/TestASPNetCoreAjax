using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestASPNetCoreAjax.Models.Data;

namespace TestASPNetCoreAjax.Controllers
{
    public class SharpController : Controller
    {

        private MyDbContext db;

        public SharpController(MyDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Sharp(){
            var a = db.Sharps.Where(id => id.Id == 1).Where(a => a.LanguageId == 1);
            ViewBag.Count = 10;
            return View("Test", a);
        }
        public IActionResult BeginerSharp()
        {
            var a = db.Sharps.Where(id => id.Id == 1).Where(a => a.LanguageId == 2);

            return View("Test", a);
        }


        public IActionResult GetCheckAnswer(string answer, int questId)
        {
            var item = db.Sharps.Where(a => a.Id == questId).Select(a => a.Answer);
            if (answer == item.First())
            {
                return Json("");
            }
            else
            {
                return Json(item.First());
            }
        }

        /// <summary>
        /// Переход по вопросам
        /// </summary>
        /// <param name="questId">Id пройденого вопроса</param>
        /// <returns></returns>
        public IActionResult GetOrderDisplay(int questId, int languageId)
        {
            var count = db.Sharps.Count(); //получение колличества вопросов
            ViewBag.NowCount = questId;
            questId++;
            languageId++;
            if (languageId > 20)
            {
                //TODO: Действия после прохождения всех тестов.
                return Json("");
            }
            else
            {
                var result = db.Sharps.Where(a => a.Id == questId);
                return Json(result);
            }
        }






        public IActionResult Privacy()
        {
            return View();
        }
    }
}
