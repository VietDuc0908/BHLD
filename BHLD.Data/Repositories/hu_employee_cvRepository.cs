using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_employee_cvRepository
    {
    }
    public class hu_employee_cvRepository : RepositoryBase<hu_district>, Ihu_employee_cvRepository
    {
        public hu_employee_cvRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
