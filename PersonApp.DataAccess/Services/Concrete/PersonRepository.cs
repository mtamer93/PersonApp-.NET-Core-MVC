using PersonApp.Core.Entities.Concrete;
using PersonApp.DataAccess.Context;
using PersonApp.DataAccess.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.DataAccess.Services.Concrete
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(AppDbContext context) : base(context)
        {

        }
    }
}
