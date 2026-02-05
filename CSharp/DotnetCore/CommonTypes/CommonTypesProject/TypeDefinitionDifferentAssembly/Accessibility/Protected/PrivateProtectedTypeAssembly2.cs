using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeDefinitionProject.Accessibility.Protected;

namespace TypeDefinitionAssembly2Project.Accessibility.Protected
{
    public class PrivateProtectedTypeAssembly2
    {
        public void Method()
        {
            var privateProtectedType = new PrivateProtectedType();
            //Private protected can not access through instantiation in a different assembly
            //var canAccessToPrivateProtectedLevel = privateProtectedType.PrivateProtectedProperty && privateProtectedType.PrivateProtectedMethod();
        }
    }

    public class PrivateProtectedDifferentAssembly : PrivateProtectedType
    {
        public void Method()
        {
            //Despite the protected type can be accessed through derived classes, if the protected type is private, it is not possible to accessed through different assembly
            //var canAccessToPrivateProtectedLevel = PrivateProtectedProperty && PrivateProtectedMethod();
        }
    }
}
