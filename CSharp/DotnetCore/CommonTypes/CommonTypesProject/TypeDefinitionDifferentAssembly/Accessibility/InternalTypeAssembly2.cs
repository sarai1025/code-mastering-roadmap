using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDefinitionAssembly2Project.Accessibility
{
    public class InternalClassDifferentAssembly
    {
        private void Method()
        {
            //Internal class can not be instanciated from an external assembly.
            //var internalClass = new InternalClass();
        }
    }

    //Internal class can not be derived from an external assembly.
    //public class InternalClassDerivedAssembly : InternalType
    //{

    //}
}
