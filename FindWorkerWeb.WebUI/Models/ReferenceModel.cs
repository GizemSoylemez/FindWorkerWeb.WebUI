using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class ReferenceModelProperty
    {

        public string ReferenceName { get; set; }
        public string ReferencePosition { get; set; }
        public string ReferencePhone { get; set; }
        public string ReferenceEmail { get; set; }
        public int UserId { get; set; }
    }
    public class ReferenceModel
    {

        public List<string> ReferenceName { get; set; }
        public List<string> ReferencePosition { get; set; }
        public List<string> ReferencePhone { get; set; }
        public List<string> ReferenceEmail { get; set; }
        public int UserId { get; set; }
    }
}
