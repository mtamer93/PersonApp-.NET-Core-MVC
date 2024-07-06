using PersonApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.DataAccess.Services.Interface
{
    public interface IPersonRepository : IBaseRepository<Person>
    {

    }
}
