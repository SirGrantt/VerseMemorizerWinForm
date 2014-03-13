using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImplementationClasses;

namespace Implementations.Test
{
    //[TestClass]
    //public class VerseRepositoryTests
    //{
    //    [TestMethod]
    //    public void GivenSearchParametersForAVerseWhenIFindTheVerseThenReturnTheRightVersesInformation()
    //    {
    //        var verseRepository = new VerseRepository();

    //        var expectedVerse = new Verse { VerseText = "For God so loved the world", Book = EBook.John, Chapter = 3, Translation = "ESV", Category = "Salvation", VerseNumber = 16 };

    //        var actualVerse = verseRepository.FindVerse(expectedVerse.Book, expectedVerse.Chapter, expectedVerse.VerseNumber);
    //        Assert.AreEqual(expectedVerse.VerseText, actualVerse.VerseText);
    //    }
    //}

    [TestClass]
    public class GivenAVerseThatDoesNotAlreadyExist
    {
        VerseRepository _verseRepository;
        Verse _newVerse;
        bool _resultOfAdd;
        Verse _foundVerse;

        [TestInitialize]
        public void WhenAddingAVerse()
        {
            _verseRepository = new VerseRepository();
            _newVerse = new Verse { VerseText = "For God so loved the world...", Book = EBook.John, Chapter = 3, VerseNumber = 16, Translation = "ESV" };
            _resultOfAdd = _verseRepository.Add(_newVerse);
            _foundVerse = _verseRepository.FindVerse(_newVerse);
        }

        [TestMethod]
        public void ItShouldReturnTrue()
        {
            Assert.IsTrue(_resultOfAdd);
        }

        [TestMethod]
        public void ItShouldAndAddTheVerseBook()
        {
           Assert.AreEqual(_foundVerse.Book, _newVerse.Book);
        }

        [TestMethod]
        public void ItShouldAndAddTheVerseText()
        {
            Assert.AreEqual(_foundVerse.VerseText, _newVerse.VerseText);
        }

        [TestMethod]
        public void ItShouldAndAddTheVerseNumber()
        {
            Assert.AreEqual(_foundVerse.VerseNumber, _newVerse.VerseNumber);
        }
    }


    public abstract class ExistingVerseContext
    {
        protected VerseRepository _verseRepository;
        protected Verse ExistingVerse { get; private set; }


        public ExistingVerseContext()
        {
            _verseRepository = new VerseRepository();
            ExistingVerse = new Verse { VerseText = "For God so loved the world...", Book = EBook.John, Chapter = 3, VerseNumber = 16, Translation = "ESV" };
            _verseRepository.Add(ExistingVerse);
        }
    }


    [TestClass]
    public class GivenAVerseThatDoesAlreadyExistWhenAddingAVerse : ExistingVerseContext
    {
        bool _resultOfAdd;

        [TestInitialize]
        public void WhenAddingAVerse()
        {
            _resultOfAdd = _verseRepository.Add(ExistingVerse);
        }

        [TestMethod]
        public void ItShouldReturnFalse()
        {
            Assert.IsFalse(_resultOfAdd);
        }
    }

    [TestClass]
    public class GivenAVerseThatDoesAlreadyExistWhenUpdatingAVerse : ExistingVerseContext
    {
        bool _resultOfUpdate;

        [TestInitialize]
        public void WhenUpdatingAVerse()
        {
            _resultOfUpdate = _verseRepository.Update(ExistingVerse);
        }

        [TestMethod]
        public void ItShouldReturnTrue()
        {
            Assert.IsTrue(_resultOfUpdate);
        }
    }

}
