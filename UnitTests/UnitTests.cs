namespace UnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using OSISP_Lab2;

    /// <summary>
    /// The unit tests.
    /// </summary>
    [TestClass]
    public class UnitTests
    {
        /// <summary>
        /// The test method 1.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            var types  = typeof(RedColor).Assembly.GetTypes();
        }

        /// <summary>
        /// The test method 2.
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            var cmpClass = typeof(AbstractRedColor);
            var cmpInterface = typeof(IYellowColor);

            var abstractCollection = new List<object>();
            var interfaceCollection = new List<object>();

            var collection = new List<object> { new RedColor(), new OrangeColor(), new YellowColor() };

            foreach (var per in collection)
            {
                var baseType = per.GetType().GetTypeInfo().BaseType;

                if (baseType != null && baseType.Name == cmpClass.Name)
                {
                    abstractCollection.Add(per);
                }

                if (per.GetType().GetTypeInfo().ImplementedInterfaces.FirstOrDefault(x => x.Name == cmpInterface.Name)
                    != null)
                {
                    interfaceCollection.Add(per);
                }
            }
        }
    }
}
