using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        StoreEntities dbContext;
        MasterEntities masterContext;

        public StoreEntities Init()
        {
            return dbContext ?? (dbContext = new StoreEntities());
        }

        public MasterEntities InitMaster()
        {
            return masterContext ?? (masterContext = new MasterEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();

            if (masterContext != null)
                masterContext.Dispose();
        }
    }
}
