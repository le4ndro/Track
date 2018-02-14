using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Track.Model.Models;

namespace Track.Data.Configuration
{
    public class ProjectConfiguration : EntityTypeConfiguration<Project>
    {
        public ProjectConfiguration()
        {
            ToTable("Projects");
            Property(p => p.Name).IsRequired();
            Property(p => p.Description).IsRequired();
        }

    }
}
