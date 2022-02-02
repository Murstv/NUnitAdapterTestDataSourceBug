using NUnit.Framework;
using System;
using System.Collections;

namespace NUnitAdapterTestDataSourceBug
{
    public class Tests
    {
        static IEnumerable Data_Test1()
        {
            return new object[]
            {
                new object[]
                {
                    1,1
                },
            };
        }

        [TestCaseSource(nameof(Data_Test1))]
        public void Test1ShowOk(int a, int b)
        {
            Assert.AreEqual(a, b);
        }

        static IEnumerable Data_Test2()
        {
            return new object[]
            {
                new object[]
                {
                    BuildInt(), 1
                },
            };
        }

        static int BuildInt() {
            var random = new Random();
            return random.Next(); 
        }

        [TestCaseSource(nameof(Data_Test2))]
        public void Test2NotShowing(int a, int b)
        {
            Assert.AreEqual(a, b);
        }
    }
}
