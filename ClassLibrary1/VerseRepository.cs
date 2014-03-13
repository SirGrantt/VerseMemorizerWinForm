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

        //public int AssignID(Verse verse)
        //{
        //    verse.ID =
        //    return verse.ID;
        //}

        public Verse FindVerse(Verse verse)
        {
            return _verseStorage.SingleOrDefault(x => x.Book == verse.Book && x.VerseText == verse.VerseText && x.VerseNumber == verse.VerseNumber
                && x.Chapter == verse.Chapter && x.Translation == verse.Translation);

        }

        public bool Update(Verse verse, Verse verseChanges)
        {
            //FindVerse(verse);
            //verse.Book = verseChanges.Book;
            //return verse;

            //FindVerse(verse);
            //verse = _verseStorage.FirstOrDefault(x => x.Book == verse.Book);
            //verse.Book = verseChanges.Book;

            if (_verseStorage.Contains(verse))
            {
                verse = verseChanges;

                //verse.Book = verseChanges.Book;
                //verse.Chapter = verseChanges.Chapter;
                //verse.Translation = verseChanges.Translation;
                //verse.VerseNumber = verseChanges.VerseNumber;
                //verse.VerseText = verseChanges.VerseText;
                return true;

            }
            else return false; 
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
