using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Track.Data.Infrastructure;
using Track.Model.Models;

namespace Track.Data.Repositories
{
    public class ProjectRepository : RepositoryBase<Project> , IProjectRepository
    {
        public ProjectRepository(IDbFactory dbFactory) : base (dbFactory: dbFactory)
        {

        }

        
    }

    public interface IProjectRepository : IRepository<Project> { }
}
