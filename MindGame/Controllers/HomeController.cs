using Newtonsoft.Json;
using MindGame.DAL;
using MindGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MindGame.Controllers
{
    public class HomeController : Controller
    {
        private QuizContext db = new QuizContext();
        public ActionResult Index()
        {
         
            var query = db.Quizs.Take(6).ToList();
            return View(query);
        }
        // 測驗結果
        public ActionResult About(int quizID)
        {
            var query = db.Quizs.Where(x => x.ID == quizID).SingleOrDefault();
            return View(query);
        }

        public string ReadAnswer(int anaId) {         
            var query = db.QuizAnalyzes.Where(x => x.QuizAnalyzeID == anaId)
                .Select(y=>y.Explanation).SingleOrDefault();
            return query.ToString();
        }
        public string changeQuiz() {
            // select * from table order rand(Now());
            // OrderBy(x => Guid.NewGuid())
            // 以當前時間為亂數的排序條件，就以亂數取得資眼庫的記錄
            List<Quiz> query =db.Quizs.OrderBy(x => Guid.NewGuid()).Take(6).ToList();

            List<QuizForJson> quiz = new List<QuizForJson>();
            foreach (var item in query)
            {
                quiz.Add(new QuizForJson {ID=item.ID,title=item.title,description=item.description });
            }
            //將List序列化成JSON格式的字串
            string q=JsonConvert.SerializeObject(quiz);
            return q;
        }
        public class QuizForJson
        {           
            public int ID { get; set; }
            public string title { get; set; } // 標題
            public string description { get; set; } // 描述
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}