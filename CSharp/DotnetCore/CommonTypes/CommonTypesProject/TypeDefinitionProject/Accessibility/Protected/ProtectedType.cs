using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDefinitionProject.Accessibility.Protected
{
    //this class can not be protected, the only access allowed is public and internal
    public class ProtectedType
    {
        protected bool ProtectedProperty { get; set; }
        protected bool ProtectedMethod() { return ProtectedProperty; }
    }

    public class ProtectedTypeSameAssebly
    {
        public void Method()
        {
            var protectedType = new ProtectedType();

            //Can not access to protected level because it is instantiated, only derived or itself class can do.
            //var canAccessToProtectedLevel = protectedType.ProtectedProperty && ProtectedProperty.ProtectedMethod();
        }
    }

    public class ProtectedTypeDerivedSameAssembly : ProtectedType
    {
        public void Method()
        {
            var canAccessToProtectedLevel = ProtectedProperty && ProtectedMethod();
        }
    }
}
