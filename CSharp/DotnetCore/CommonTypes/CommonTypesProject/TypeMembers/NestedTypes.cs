using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeMembers
{
    public class Container
    {
        public int ContainerProp { get; set; }

        public void ContainerMethod()
        {
            var nested = new Nested();
            var tempNestedProp = nested.NestedProperty;
        }

        public class Nested
        {
            public Container parent;
            public int NestedProperty { get; set; }
            public Nested()
            {
                
            }
            public Nested(Container parent)
            {
                this.parent = parent;
                NestedProperty = parent.ContainerProp;
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
