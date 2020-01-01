using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
 public class WorkExperienceModelProperty
    {

        public string CompanyName { get; set; }
        public string Position { get; set; }
        public DateTime WorkedTime { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
    }
    public class WorkExperienceModel
    {

        public List<string> CompanyName { get; set; }
        public List<string> Position { get; set; }
        public List<DateTime> WorkedTime { get; set; }
        public List<string> Description { get; set; }
        public int UserId { get; set; }
    }
}
