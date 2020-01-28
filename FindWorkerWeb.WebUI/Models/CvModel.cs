using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class CvModel
    {
        public List<EducationModelProperty> Education { get; set; }
        public List<ProjectModelProperty> Project { get; set; }
        public List<SkillModelProperty> Skill { get; set; }
        public List<DocumentModelProperty> Document { get; set; }
        public List<ReferenceModelProperty> Reference { get; set; }
        public List<LanguageModelProperty> Language { get; set; }
        public List<ContactModelProperty> Contact { get; set; }
        public List<HobbyModelProperty> Hobby { get; set; }
        public List<LocationModel> Location { get; set; }
        public List<WorkExperienceModelProperty> WorkExperience { get; set; }
        public List<CvDataModelProperty> CvData { get; set; }
    }
}
