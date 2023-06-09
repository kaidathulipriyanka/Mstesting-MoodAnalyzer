using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;
using static MoodAnalyzer.Program;

namespace MoodAnalyzerTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            MoodAnalyzerClass obj = new MoodAnalyzerClass("I am in sad mood");

            // Act
            string expected = "Sad";
            string actual = obj.AnalyzeMood();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
