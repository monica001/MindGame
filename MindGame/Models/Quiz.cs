using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MindGame.Models
{
    public class Quiz
    {
        [Key]
        public int ID { get; set; }
        public string title { get; set; } // 標題
        public string description { get; set; } // 描述
        public string imagePath { get; set; }// 圖

        public virtual ICollection<QuizAnalyze> QuizAnalyze { get; set; }
    }
}