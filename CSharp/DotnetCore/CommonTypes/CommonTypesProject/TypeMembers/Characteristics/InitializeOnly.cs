using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeMembers.Characteristics
{
    internal class PersonInitializeOnly
    {
        #region Properties
        public string Name { get; init; }
        public int Age { get; set; }
        public string Mail { get; } //implicit readonly 
        #endregion
        public class InitilizeOnly
        {
            public  void Method()
            {
                var person = new PersonInitializeOnly(){ Name = "A", Age = 1 };

                //person.Mail = "a@gmail.com"; //Error: property is read only, it could never be change outside itself.
                //person.Name = "B"; //Error: init only property, can only be assign (at initialization) but not modified
                person.Age = 2;
            }
        }
    }

}
