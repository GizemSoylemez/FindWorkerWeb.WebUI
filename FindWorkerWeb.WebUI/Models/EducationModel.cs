using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class EducationModelProperty
    {

        public string SchoolName { get; set; }
        public DateTime GruadetDate { get; set; }
        public string SchoolType { get; set; }
        public string Department { get; set; }
        public int UserId { get; set; }
    }
    public class EducationModel
    {

        public List<string> SchoolName { get; set; }
        public List<DateTime> GruadetDate { get; set; }
        public List<string> SchoolType { get; set; }
        public  List<string> Department { get; set; }
        public int UserId { get; set; }
    }
}
