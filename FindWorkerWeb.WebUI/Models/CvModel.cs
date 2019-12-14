using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class CvModel
    {
        public int Id { get; set; }
        public string CvName { get; set; }
        public List<string> Education { get; set; }
        public string Project { get; set; }
        public string Skill { get; set; }
        public string Document { get; set; }
        public List<string> Reference { get; set; }
        public string Language { get; set; }
        public string Contact { get; set; }
        public string Hobby { get; set; }
        public string Location { get; set; }
        public string WorkExperience { get; set; }
    }
}
