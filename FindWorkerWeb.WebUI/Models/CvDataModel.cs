using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class CvDataModel
    {
        public List<string> CvName { get; set; }
        public int UserId { get; set; }
    }

    public class CvDataModelProperty
    {
        public string CvName { get; set; }
        public int UserId { get; set; }
    }
}
