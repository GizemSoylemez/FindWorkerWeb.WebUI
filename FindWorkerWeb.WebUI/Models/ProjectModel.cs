using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class ProjectModelProperty
    {
        public string ProjectName { get; set; }
        public int UserId { get; set; }
    }

    public class ProjectModel
    {
        public List<string> ProjectName { get; set; }
        public int UserId { get; set; }
    }
}
