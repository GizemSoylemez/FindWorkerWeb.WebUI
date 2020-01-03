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
        public int WorkStartTime { get; set; }
        public int WorkFinishTime { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
    }
    public class WorkExperienceModel
    {

        public List<string> CompanyName { get; set; }
        public List<string> Position { get; set; }
        public List<int> WorkStartTime { get; set; }
        public List<int> WorkFinishTime { get; set; }
        public List<string> Description { get; set; }
        public int UserId { get; set; }
    }
}
