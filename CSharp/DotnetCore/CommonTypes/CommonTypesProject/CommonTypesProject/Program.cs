using BenchmarkDotNet.Running;
using CommonTypesProject.Classes;
using CommonTypesProject.Structures;

BenchmarkRunner.Run<BenchmarkSealedClass>();

StructTest.Compare();