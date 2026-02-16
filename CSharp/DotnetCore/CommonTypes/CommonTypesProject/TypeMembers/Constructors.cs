using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeMembers
{
    public class Constructors
    {
    }

    public class Constructors2
    {
        public int type { get; set; }
        public Constructors2(int type)
        {
            this.type = type;
        }
    }

    public class ExampleConstructor
    {
        public void Method()
        {
            var constructor = new Constructors(); //in this case the constructor is implicit despite it was not declared
            var constructor2 = new Constructors2(1); //in this case the const without params is not valid since was decleared one with params so the empty implicit constructor does not exist
        }
    }
}
