using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class DocumentModelProperty
    {
        public string DocumentationName { get; set; }
        public DateTime DocumentDate { get; set; }
        public int UserId { get; set; }
    }
    public class DocumentModel
    {
        public List<string> DocumentationName { get; set; }
        public List<DateTime> DocumentDate { get; set; }
        public int UserId { get; set; }
    }
}
