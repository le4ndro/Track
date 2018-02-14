using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Track.Data.Infrastructure;
using Track.Data.Repositories;
using Track.Model.Models;

namespace Track.Service.Services
{
    public interface IProjectService
    {
        IEnumerable<Project> GetProjects();        
        Project GetProject(int id);
        void CreateProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(Project project);
        void SaveProject();
    }

    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository projectRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProjectService(IProjectRepository projectRepository, IUnitOfWork unitOfWork)
        {
            this.projectRepository = projectRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateProject(Project project)
        {
            projectRepository.Add(project);
        }

        public void DeleteProject(Project project)
        {
            projectRepository.Delete(project);
        }

        public Project GetProject(int id)
        {
            return projectRepository.GetById(id);
        }

        public IEnumerable<Project> GetProjects()
        {
            return projectRepository.GetAll();
        }

        public void SaveProject()
        {
            projectRepository.SaveChanges();
            unitOfWork.Commit();
        }

        public void UpdateProject(Project project)
        {
            projectRepository.Update(project);
        }
    }
}
