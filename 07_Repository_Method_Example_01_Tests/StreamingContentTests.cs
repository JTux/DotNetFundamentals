using System;
using _07_Repository_Method_Example_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_Repository_Method_Example_01_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void StreamingContent_SetTitle_ShouldBeCorrectString()
        {
            //-- Arrange
            StreamingContent content = new StreamingContent();
            content.Title = "Jaws";

            //-- Act
            string actual = content.Title;
            string expected = "Jaws";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContent_SetIsMature_ShouldBeCorrectString()
        {
            //-- Arrange
            StreamingContent content = new StreamingContent();
            content.IsMature = true;

            //-- Act
            bool actual = content.IsMature;
            bool expected = true;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContent_Constructor_ShouldHoldCorrectValues()
        {
            //-- Arrange
            StreamingContent content = new StreamingContent("title","genre",2,true);

            //-- Act
            string actual = content.Genre;
            string expected = "genre";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
