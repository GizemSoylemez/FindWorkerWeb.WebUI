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
        public List<EducationModel> Education { get; set; }
        public List<ProjectModel> Project { get; set; }
        public List<SkillModel> Skill { get; set; }
        public List<DocumentModel> Document { get; set; }
        public List<ReferenceModel> Reference { get; set; }
        public List<LanguageModel> Language { get; set; }
        public List<ContactModel> Contact { get; set; }
        public List<HobbyModel> Hobby { get; set; }
        public List<LocationModel> Location { get; set; }
        public List<WorkExperienceModel> WorkExperience { get; set; }
    }
}
