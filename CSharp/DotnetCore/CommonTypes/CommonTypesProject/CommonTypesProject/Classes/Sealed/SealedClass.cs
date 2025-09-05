using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypesProject.Classes.Sealed
{
    public class BaseClass //: SealedClass
    {
        //This class can not inherit to SealedClass as a parent class


        #region Methods
        public virtual void ExampleVoidMethod() { }
        public virtual int ExampleIntMethod() => 0;
        #endregion
    }


    public sealed class SealedClass : BaseClass
    {
        //This class can not be inherited from any other class because is sealed


        #region Methods
        public override void ExampleVoidMethod() { }
        public override int ExampleIntMethod() =>10;
        #endregion
    }


    public class NotSealedClass : BaseClass
    {

        #region Methods
        public override void ExampleVoidMethod() { }
        public override int ExampleIntMethod() => 10;
        #endregion
    }
}
