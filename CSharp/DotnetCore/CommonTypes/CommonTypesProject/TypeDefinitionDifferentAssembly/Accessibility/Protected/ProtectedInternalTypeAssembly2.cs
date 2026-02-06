using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeDefinitionProject.Accessibility.Protected;

namespace TypeDefinitionAssembly2Project.Accessibility.Protected
{
    public class ProtectedInternalTypeAssembly2
    {
        public void Method()
        {
            var protectedInternalType = new ProtectedInternalType();
            //The only level that a protected internal is not allowed is for an instantiation in a different assembly
            //var canAccessToProtectedInternalLevel = protectedInternalType.ProtectedInternalProperty && protectedInternalType.ProtectedInternalMethod();
        }
    }

    public class ProtectedInternalDerivedDifferentAssembly : ProtectedInternalType
    {
        public void Method()
        {
            var canAccessToProtectedInternalLevel = ProtectedInternalProperty && ProtectedInternalMethod();
        }
    }


}
