using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api = ex2_API.Models;
using dal = ex2_DAL.Models;

namespace ex2_API.Mappers
{
    public static class PersonMappers
    {
        public static dal.Person ToDal(this api.PersonApi api)
        {
            dal.Person dal = new dal.Person();

            dal.FirstName = api.FirstName;
            dal.LastName = api.LastName;

            return dal;
        }
    }
}
