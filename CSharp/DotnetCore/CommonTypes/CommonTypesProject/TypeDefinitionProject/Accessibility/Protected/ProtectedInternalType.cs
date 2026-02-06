using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDefinitionProject.Accessibility.Protected
{
    public class ProtectedInternalType
    {
        protected internal bool ProtectedInternalProperty { get; set; }
        protected internal bool ProtectedInternalMethod() { return ProtectedInternalProperty; }
    }

    public class ProtectedInternalSameAssembly
    {
        public void Method()
        {
            var protectedInternalType = new ProtectedInternalType();
            var canAccessToProtectedInternalLevel = protectedInternalType.ProtectedInternalProperty && protectedInternalType.ProtectedInternalMethod();
        }
    }

    public class ProtectedInternalDerivedSameAssembly : ProtectedInternalType
    {
        public void Method()
        {
            var canAccessToProtectedInternalLevel = ProtectedInternalProperty && ProtectedInternalMethod();
        }
    }
}
