using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeDefinitionProject.Accessibility;

namespace TypeDefinitionAssembly2Project.Accessibility
{
    internal class PrivateTypeAssembly2 : PublicType
    {
        public void Method()
        {
            var publicClass = new PublicType();
            //Private properties or methods can not be accessed from any where (in this case from a different assembly)
            //var canAccessToInternalFromPublicClass = PrivateProperty && PrivateMethod() && publicClass.PrivateProperty && publicClass.PrivateMethod();

        }
    }
}
