using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class HobbyModelProperty
    {
        public string HobbiesName { get; set; }
        public int UserId { get; set; }
    }
    public class HobbyModel
    {
        public List<string> HobbiesName { get; set; }
        public int UserId { get; set; }

    }
}
