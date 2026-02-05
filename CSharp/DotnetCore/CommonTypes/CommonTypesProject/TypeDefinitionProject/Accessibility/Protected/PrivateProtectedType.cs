using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDefinitionProject.Accessibility.Protected
{
    public class PrivateProtectedType
    {
        private protected bool PrivateProtectedProperty {  get; set; }
        private protected bool PrivateProtectedMethod() {  return PrivateProtectedProperty; }
    }

    public class PrivateProtectedSameAssembly
    {
        public void Method()
        {
            var privateProtectedType = new PrivateProtectedType();
            //Private protected can not access through instantiation despite it is the same assembly
            //var canAccessToPrivateProtectedLevel = privateProtectedType.PrivateProtectedProperty && privateProtectedType.PrivateProtectedMethod();
        }
    }

    public class PrivateProtectedDifferentAssembly : PrivateProtectedType
    {
        public void Method()
        {
            var canAccessToPrivateProtectedLevel = PrivateProtectedProperty && PrivateProtectedMethod();
        }
    }
}
