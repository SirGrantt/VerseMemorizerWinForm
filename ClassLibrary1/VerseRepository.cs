using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationClasses
{
    public class VerseRepository  
    {
        private readonly List<Verse> _verseStorage = new List<Verse>();

        public bool Add(Verse verse)
        {
            if (_verseStorage.Contains(verse))
            {
                return false;
            }
            _verseStorage.Add(verse);
            return true;
        }

        public Verse FindVerse(Verse verse)
        {
            return _verseStorage.SingleOrDefault(x => x.Book == verse.Book && x.VerseText == verse.VerseText && x.VerseNumber == verse.VerseNumber
                && x.Chapter == verse.Chapter && x.Translation == verse.Translation);

        }

        public bool Update(Verse verse)
        {
            FindVerse(verse);
            if (_verseStorage.Contains(verse))
            {
                var verseChanges = new Verse();
                verse.Book = verseChanges.Book;
                verse.Chapter = verseChanges.Chapter;
                verse.Translation = verseChanges.Translation;
                verse.VerseNumber = verseChanges.VerseNumber;
                verse.VerseText = verseChanges.VerseText;
                return true;

            }
            else return false;
        }
    }
}
