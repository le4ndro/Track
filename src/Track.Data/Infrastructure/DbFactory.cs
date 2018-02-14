using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Track.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        TrackEntities dbContext;

        public TrackEntities Init()
        {
            return dbContext ?? (dbContext = new TrackEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
