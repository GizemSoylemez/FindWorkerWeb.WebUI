using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindWorkerWeb.WebUI.Helper;
using FindWorkerWeb.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FindWorkerWeb.WebUI.Controllers
{
    public class UserController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult Profile()
        {
          
            return View();
        }

        public IActionResult Cv1()
        {
            return View();
        }
        public IActionResult Cv2()
        {
            return View();
        }
        public IActionResult Cv3()
        {
            return View();
        }
        public IActionResult ExampleCv1()
        {
            return View();
        }
        public IActionResult ExampleCv2()
        {
            return View();
        }
        public IActionResult ExampleCv3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CVData([FromForm] ProjectModel projectModel ,DocumentModel documentModel,ContactModel contactModel, EducationModel educationModel,HobbyModel hobbyModel,LanguageModel languageModel,LocationModel locationModel,ReferenceModel referenceModel,SkillModel skillModel,WorkExperienceModel experienceModel)
        {
            var userdata = HttpContext.Session.GetString("Id");
            List<EducationModelProperty> educationList = new List<EducationModelProperty>();
            List<ContactModelProperty> contactList = new List<ContactModelProperty>();
            List<ReferenceModelProperty> referenceList = new List<ReferenceModelProperty>();
            List<WorkExperienceModelProperty> experienceList = new List<WorkExperienceModelProperty>();
            List<ProjectModelProperty> projectList = new List<ProjectModelProperty>();
            List<LanguageModelProperty> languageList = new List<LanguageModelProperty>();
            List<DocumentModelProperty> documentList = new List<DocumentModelProperty>();
            List<SkillModelProperty> skillList = new List<SkillModelProperty>();
            List<HobbyModelProperty> hobbyList = new List<HobbyModelProperty>();
            for (int i = 0; i < educationModel.SchoolName.Count; i++)
            {

                EducationModelProperty response = new EducationModelProperty();
                response.SchoolName = educationModel.SchoolName[i];
                response.GruadetDate = educationModel.GruadetDate[i];
                response.SchoolType = educationModel.SchoolType[i];
                response.Department = educationModel.Department[i];
                response.UserId = Convert.ToInt32(userdata);
                educationList.Add(response);
                ApiHelper.Post("Education/AddEducation", response);
            }

            for (int i = 0; i < contactModel.ContactName.Count; i++)
            {
                ContactModelProperty response = new ContactModelProperty();
                response.ContactName = contactModel.ContactName[i];
                response.Decription = contactModel.Decription[i];
                response.UserId = Convert.ToInt32(userdata);
                contactList.Add(response);
                ApiHelper.Post("Contact/AddContact", response);
            }

            for (int i = 0; i < referenceModel.ReferenceName.Count; i++)
            {
                ReferenceModelProperty response = new ReferenceModelProperty();
                response.ReferenceName = referenceModel.ReferenceName[i];
                response.ReferenceEmail = referenceModel.ReferenceEmail[i];
                response.ReferencePhone = referenceModel.ReferencePhone[i];
                response.ReferencePosition = referenceModel.ReferencePosition[i];
                response.UserId = Convert.ToInt32(userdata);
                referenceList.Add(response);
                ApiHelper.Post("Reference/AddReference", response);
            }

            for (int i = 0; i < experienceModel.CompanyName.Count; i++)
            {
                WorkExperienceModelProperty response = new WorkExperienceModelProperty();
                response.CompanyName = experienceModel.CompanyName[i];
                response.Description = experienceModel.Description[i];
                response.Position = experienceModel.Position[i];
                response.WorkFinishTime = experienceModel.WorkFinishTime[i];
                response.WorkStartTime = experienceModel.WorkStartTime[i];
                response.UserId = Convert.ToInt32(userdata);
                experienceList.Add(response);

                ApiHelper.Post("WorkExperience/AddWorkExperience", response);

            }
            for (int i = 0; i < projectModel.ProjectName.Count; i++)
            {
                ProjectModelProperty response = new ProjectModelProperty();
                response.ProjectName = projectModel.ProjectName[i];
                response.UserId = Convert.ToInt32(userdata);
                projectList.Add(response);
                ApiHelper.Post("Project/AddProject", response);
            }
            for (int i = 0; i < languageModel.LanguageLevel.Count; i++)
            {
                LanguageModelProperty response = new LanguageModelProperty();
                response.LanguageName = languageModel.LanguageName[i];
                response.LanguageLevel = languageModel.LanguageLevel[i];
                response.UserId = Convert.ToInt32(userdata);
                languageList.Add(response);
                ApiHelper.Post("Language/AddLanguage", response);
            }
            for (int i = 0; i < documentModel.DocumentDate.Count; i++)
            {
                DocumentModelProperty response = new DocumentModelProperty();
                response.DocumentationName = documentModel.DocumentationName[i];
                response.DocumentDate = documentModel.DocumentDate[i];
                response.UserId = Convert.ToInt32(userdata);
                documentList.Add(response);
                ApiHelper.Post("Document/AddDocument", response);
            }
            for (int i = 0; i < skillModel.SkillName.Count; i++)
            {
                SkillModelProperty response = new SkillModelProperty();
                response.SkillName = skillModel.SkillName[i];
                response.SkillLevel = skillModel.SkillLevel[i];
                response.UserId = Convert.ToInt32(userdata);
                skillList.Add(response);
                ApiHelper.Post("Skill/AddSkill", response);
            }
            for (int i = 0; i < hobbyModel.HobbiesName.Count; i++)
            {
                HobbyModelProperty response = new HobbyModelProperty();
                response.HobbiesName = hobbyModel.HobbiesName[i];
                response.UserId = Convert.ToInt32(userdata);
                hobbyList.Add(response);
                ApiHelper.Post("Skill/AddSkill", response);
            }

            return Redirect("Home/AnaSayfa");
        }
            
    }
}