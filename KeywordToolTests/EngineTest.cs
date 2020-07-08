using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Keyword_Tool;

namespace KeywordToolTests
{
    [TestClass]
    public class EngineTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> testInput = new List<string>();
            testInput.Add("Weterynarz Opole Całodobowy");
            HashSet<string> result = Engine.GenerateKeywords(testInput);

            Assert.IsTrue(result.Contains("[Weterynarz Opole Całodobowy]"));
            Assert.IsTrue(result.Contains("[Weterynarz Całodobowy Opole]"));
            Assert.IsTrue(result.Contains("[Opole Weterynarz Całodobowy]"));
            Assert.IsTrue(result.Contains("[Opole Całodobowy Weterynarz]"));
            Assert.IsTrue(result.Contains("[Całodobowy Weterynarz Opole]"));
            Assert.IsTrue(result.Contains("[Całodobowy Opole Weterynarz]"));
            Assert.IsTrue(result.Contains("+Weterynarz +Opole +Całodobowy"));
        }
    }
}
