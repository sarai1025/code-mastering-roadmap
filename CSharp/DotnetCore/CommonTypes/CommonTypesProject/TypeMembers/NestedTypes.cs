using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeMembers
{
    public class Container
    {
        public class Nested
        {
            public Container parent;

            public Nested()
            {
                
            }
            public Nested(Container parent)
            {
                this.parent = parent;
            }
        }
    }

    public class ExampleNestedTypes
    {
        public void Method()
        {
            //var nestedError = new Nested(); To access to nested class is required access first to the container, not directly
            var container = new Container();
            var nest = new Container.Nested();
        }
    }
}
