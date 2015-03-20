using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

// ReSharper disable CheckNamespace
namespace LiveSDKHelper.Test.ScopeEnum
{
    [TestClass]
    public class ScopeTest
    {
        [TestMethod]
        public void MustEachHaveUniqueScopeName()
        {
            FieldInfo[] fieldinfoArray = typeof(Scope).GetFields(System.Reflection.BindingFlags.Static);
            List<string> fieldInfoNames = new List<string>();
            foreach (var fi in fieldinfoArray)
            {
                fieldInfoNames.Add(fi.GetRawConstantValue().ToString());
            }

            int scopesCount = fieldinfoArray.Length;
            int scopesNameCount = fieldInfoNames.Distinct().Count();
            Assert.AreEqual(scopesCount, scopesNameCount);
        }
    }
}
