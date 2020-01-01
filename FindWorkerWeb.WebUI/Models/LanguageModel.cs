using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class LanguageModelProperty
    {
        public string LanguageName { get; set; }
        public int LanguageLevel { get; set; }
        public int UserId { get; set; }
    }
    public class LanguageModel
    {
        public List<string> LanguageName { get; set; }
        public List<int> LanguageLevel { get; set; }
        public int UserId { get; set; }
    }
}
