using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestASPNetCoreAjax.Models
{
    public abstract class Language
    {
        public int Id { get; set; }
        public string Quest { get; set; }
        public string Answer { get; set; }
        public string Wrong1 { get; set; }
        public string Wrong2 { get; set; }
        public string Wrong3 { get; set; }
        public int LanguageId { get; set; }
    }
}
