using gamesimulation.Abstract;
using gamesimulation.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamesimulation.concrete
{
    public class PersonManager : BasisPersonManage
    {
       IPersonCheckService personCheckService;

      

       public PersonManager(IPersonCheckService personCheckService)
        {
            this.personCheckService = personCheckService;
        }

        public override void Add(Person person)
        {
            if (personCheckService.personcheckresult(person))
            {
                base.Add(person);
            }
           
        }
    }
}
