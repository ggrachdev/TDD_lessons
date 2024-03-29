﻿using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace _006_RhinoGenerateStub
{
    [TestFixture]
    class TestMockTestTest
    {
        delegate string TestDelegate(int inp);

        [Test]
        public static void RhinoMockReturnsTestValue()
        {
            MockRepository rhinoEngine = new MockRepository();

            ITestMock testMock = rhinoEngine.DynamicMock<ITestMock>();

            using (rhinoEngine.Record())
            {
                testMock.ReturnSomeString(1);
                LastCall.Return("string1");

                testMock.ReturnSomeString(2);
                LastCall.Throw(new ArgumentException());

                int input = 3;
                testMock.ReturnSomeString(input);
                LastCall.Do(new TestDelegate((inp) => "string"+inp));
            }

            string result = testMock.ReturnSomeString(1);
            Assert.AreEqual("string1", result);

            Assert.Throws<ArgumentException>(() => testMock.ReturnSomeString(2));

            result = testMock.ReturnSomeString(3);
            Assert.AreEqual("string3", result);
        }

  
    }
}
