using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeDefinitionProject.Accessibility;

namespace TypeDefinitionAssembly2Project.Accessibility
{
    public class InternalClassDifferentAssembly
    {
        private void Method()
        {
            //Internal class can not be instanciated from an external assembly.
            //var internalClass = new InternalClass();

            var publicClass = new PublicClass(); //the public class can be accessed but not the internal properties or methods. 
            //The accesibility level belongs to the property, method or class. it is not a combination between them.
            //var canAccessToInternalFromPublicClass = publicClass.InternalProperty && publicClass.InternalMethod();
        }
    }

    //Internal class can not be derived from an external assembly.
    public class InternalClassDerivedAssembly : PublicClass //InternalType
    {
        public void Method()
        {
            //var canAccessToInternalFromPublicClass = InternalProperty && InternalMethod();
        }
    }
}
