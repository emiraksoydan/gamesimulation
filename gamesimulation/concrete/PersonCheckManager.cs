using gamesimulation.Abstract;
using gamesimulation.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamesimulation.concrete
{
    public class PersonCheckManager : IPersonCheckService
    {
        public bool personcheckresult(Person person)
        {
            return true;
        }
    }
}
