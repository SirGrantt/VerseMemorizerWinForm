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
            AssignID(verse);
            return true;
        }

        public int AssignID(Verse verse)
        {
            verse.ID = _verseStorage.Max(x=> x.ID + 1);
            return verse.ID;
        }

        public Verse FindVerse(Verse verse)
        {
            return _verseStorage.SingleOrDefault(x => x.Book == verse.Book && x.VerseText == verse.VerseText && x.VerseNumber == verse.VerseNumber
                && x.Chapter == verse.Chapter && x.Translation == verse.Translation);

        }

        public void Update(Verse verse)
        {
            _verseStorage.Find(x => x.ID == verse.ID);


            if (_verseStorage.Find(x => x.ID == verse.ID) != null)
            {
                verse.Book = verse.Book;
                verse.Chapter = verse.Chapter;
                verse.Translation = verse.Translation;
                verse.VerseNumber = verse.VerseNumber;
                verse.VerseText = verse.VerseText;
            }
            else return;
        }

        public bool Remove(Verse verse)
        {
            if (_verseStorage.Contains(verse))
            {
                _verseStorage.Remove(verse);
                return true;
            }
            else return false;
        }
    }
}
