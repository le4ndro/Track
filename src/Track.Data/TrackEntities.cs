using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Track.Data.Configuration;
using Track.Model.Models;

namespace Track.Data
{
    public class TrackEntities : DbContext
    {
        public TrackEntities() : base("TrackEntities") { }
        
        public DbSet<Project> Projects { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Configurations.Add(new ProjectConfiguration());
        }
    }
}
