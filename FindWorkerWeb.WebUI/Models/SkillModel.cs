using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class SkillModelProperty
    {
        public string SkillName { get; set; }
        public string SkillLevel { get; set; }
        public int UserId { get; set; }
    }
    public class SkillModel
    {
        public List<string> SkillName { get; set; }
        public List<string> SkillLevel { get; set; }
        public int UserId { get; set; }
    }
}
