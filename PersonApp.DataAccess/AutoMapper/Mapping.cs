using AutoMapper;
using PersonApp.Core.DTO;
using PersonApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.DataAccess.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping() 
        { 
            CreateMap<Person, PersonDTO>().ReverseMap();
        }
    }
}
