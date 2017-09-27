using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace popsicle.Models
{
    public class QuizAnalyze
    {
         [Key]
        public int QuizAnalyzeID { get; set; }
        public int QuizID { get; set; }
        public string Option { get; set; }  // 選項
        public string Explanation { get; set; } // 說明

        public virtual Quiz Quiz { get; set; }
    }
}