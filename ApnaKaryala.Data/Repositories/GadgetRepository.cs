using ApnaKaryala.Data.Infrastructure;
using ApnaKaryala.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Repositories
{
    public class GadgetRepository : RepositoryBase<Gadget>, IGadgetRepository
    {
        public GadgetRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IGadgetRepository : IRepository<Gadget>
    {

    }
}
