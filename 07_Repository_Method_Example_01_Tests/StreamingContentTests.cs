using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void StreamingContentRepository_AddContentToList_IsCorrectCount()
        {
            //-- Arrange
            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToList(new StreamingContent("title", "genre", 2, true));

            List<StreamingContent> testList = repo.GetContentList();
            testList.Sort((x,y) => string.Compare(x.Title, y.Title));
            int count = testList.Count;

            //-- Act
            var expected = 1;
            var actual = testList.Count;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
