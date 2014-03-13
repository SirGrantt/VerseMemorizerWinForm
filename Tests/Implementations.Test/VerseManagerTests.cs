using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImplementationClasses;

namespace Implementations.Test
{
    public abstract class GivenVerseContext
    {
        protected Verse GivenVerse { get; private set; }
        protected VerseRepository _verseRepository;

        public GivenVerseContext()
        {
            _verseRepository = new VerseRepository();
            GivenVerse = new Verse { Book = EBook.John, Chapter = 3, VerseNumber = 16, VerseText = "For God so loved the world...", Translation = "ESV" };

        }

    }
    //[TestClass]
    //public class GivenAVerseToGiveToTheRepository : GivenVerseContext
    //{

    //    [TestInitialize]

    //    public void WhenTheVerseNeedsToBeSavedToTheList()
    //    {
    //        _verseRepository.FindVerse(GivenVerse);
    //    }

    //    [TestMethod]
    //    public void ItShouldGiveItToTheRepositoryForASuccesfulSave
    //    {

    //    }
    //}
}
