using System;
using System.Collections.Generic;
using System.Reflection;
using ClinicalReporting.Common;

namespace ClinicalReporting.Services
{
    public class TestFactory : IDisposable
    {
        private static readonly NullTest nullTest = new NullTest();
        private Dictionary<string, Type> _tests;

        public TestFactory()
        {
            LoadTypesReturn();
        }

        public void Dispose()
        {
        }

        private void LoadTypesReturn()
        {
            _tests = new Dictionary<string, Type>();
            var typesInAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in typesInAssembly)
                if (type.GetInterface(typeof(ITest).ToString()) != null) _tests.Add(type.Name.ToLower(), type);
        }

        private Type GetType(string TestName)
        {
            foreach (var test in _tests)
                if (test.Key.Contains(TestName.ToLower())) return _tests[test.Key];
            return null;
        }

        public ITest CreateInstance(string testName)
        {
            var type = GetType(testName + "TestVM");
            if (type == null) return nullTest;
            return Activator.CreateInstance(type) as ITest;
        }

        public ITest CreateInstance(string testName, IModelCommon testObj)
        {
            var type = GetType(testName + "TestVM");
            if (type == null) return nullTest;
            var ctor = type.GetConstructor(new[] {typeof(IModelCommon)});
            return ctor.Invoke(new object[] {testObj}) as ITest;
        }

        public Tuple<string, ITest> CreateInstance(IModelCommon testObj)
        {
            var name = testObj.GetType().Name;
            var type = GetType(name + "TestVM");
            if (type == null) return new Tuple<string, ITest>("", nullTest);
            ;
            var ctor = type.GetConstructor(new[] {typeof(IModelCommon)});
            return new Tuple<string, ITest>(name + "TestVM", ctor.Invoke(new object[] {testObj}) as ITest);
        }
    }
}