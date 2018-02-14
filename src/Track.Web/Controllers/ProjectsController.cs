using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Track.Model.Models;
using Track.Service.Services;
using Track.Web.ViewModels;

namespace Track.Web.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IProjectService projectService;

        public ProjectsController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        // GET: Projects
        public ActionResult Index()
        {
            IEnumerable<ProjectViewModel> viewModelsProjects;
            IEnumerable<Project> projects;

            projects = projectService.GetProjects().ToList();

            viewModelsProjects = Mapper.Map<IEnumerable<Project>, IEnumerable<ProjectViewModel>>(projects);
            return View(viewModelsProjects);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProjectViewModel newProject)
        {           
            if (newProject != null)
            {
                Project project = Mapper.Map<ProjectViewModel, Project>(newProject);
                projectService.CreateProject(project);
                projectService.SaveProject();
            }
            
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Project project = projectService.GetProject((int)id);

            if (project == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<ProjectViewModel>(project));
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Project project = projectService.GetProject((int)id);

            if (project == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<ProjectViewModel>(project));
        }

        [HttpPost]
        public ActionResult Edit(ProjectViewModel project)
        {
            if (project != null)
            {
                projectService.UpdateProject(Mapper.Map<Project>(project));
                projectService.SaveProject();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Project project = projectService.GetProject((int)id);

            if (project == null)
            {
                return HttpNotFound();
            }

            projectService.DeleteProject(project);
            projectService.SaveProject();

            return RedirectToAction("Index");
        }
    }
}