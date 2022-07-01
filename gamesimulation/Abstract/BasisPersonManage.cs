using gamesimulation.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamesimulation.Abstract
{
    public abstract class BasisPersonManage : IPersonService
    {
        public virtual void Add(Person person)
        {
            Console.WriteLine(person.Name + "" + "User  saved");
        }

        public virtual void Delete(Person person)
        {
            Console.WriteLine(person.Name + "" + "User  deleted");
        }

        public virtual void Update(Person person)
        {
            Console.WriteLine(person.Name + "" + "User  updated");
        }
    }
}
