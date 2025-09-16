using BenchmarkDotNet.Attributes;

namespace CommonTypesProject.Classes
{
    [MemoryDiagnoser(false)]
    public class BenchmarkSealedClass
    {
        //To execute this class change configuration manager to RELEASE!

        private readonly BaseClassForSealedExample baseClass = new BaseClassForSealedExample();
        private readonly SealedClass sealedClass = new SealedClass();
        private readonly NotSealedClass notSealedClass = new NotSealedClass();

        private readonly SealedClass[] sealedArray = new SealedClass[1];
        private readonly NotSealedClass[] notSealedArray = new NotSealedClass[1];

        //Comparing Void Method
        [Benchmark]
        public void SealedVoid() => sealedClass.ExampleVoidMethod();

        [Benchmark]
        public void NotSealedVoid() => notSealedClass.ExampleVoidMethod();


        //Comparing Int Method
        [Benchmark]
        public int SealedInt() => sealedClass.ExampleIntMethod() + 15;

        [Benchmark]
        public int NotSealedInt() => notSealedClass.ExampleIntMethod() + 15;


        //Comparing Bool
        [Benchmark]
        public bool SealedBool() => baseClass is SealedClass;

        [Benchmark]
        public bool NotSealedBool() => baseClass is NotSealedClass;


        //Comparing store in array
        [Benchmark]
        public void StoreSealedClass() => sealedArray[0] = sealedClass;

        [Benchmark]
        public void StoreNotSealedClass() => notSealedArray[0] = notSealedClass;
    }
}
