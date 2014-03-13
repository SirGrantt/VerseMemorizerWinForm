using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationClasses
{
    public class Verse
    {
        public EBook Book { get; set; }
        public int Chapter { get; set; }
        public string Translation { get; set; }
        public string VerseText { get; set; }
        public int VerseNumber { get; set; }
        public int ID { get; set; }
    }

    public enum EBook
    {
        Genesis,
        Exodus,
        Leviticus,
        Numbers,
        Deuteronomy,
        Joshhua,
        Judges,
        Ruth,
        First_Samuel,
        Second_Samuel,
        First_Kings,
        Second_Kings,
        First_Chronicles,
        Second_Chronicles,
        Ezra, 
        Nehemiah,
        Esther,
        Job,
        Psalms,
        Provers,
        Ecclesiastes,
        Song_of_Solomon,
        Isaiah,
        Jeremiah,
        Lementations,
        Ezekiah,
        Daniel,
        Hosea,
        Joel,
        Amos,
        Obadiah,
        Jonah,
        Micah,
        Nahum,
        Habakkuk,
        Zephaniah,
        Haggai,
        Zechariah,
        Malachi,
        Matthew,
        Mark,
        Luke,
        John,
        Acts,
        Romans,
        First_Corinthians,
        Second_Corinthians,
        Galatians,
        Ephesians,
        Philippians,
        Colossians,
        First_Thessalonians,
        Second_Thessalonians,
        First_Timothy,
        Second_Timothy,
        Titus,
        Philemon,
        Hebrews,
        James,
        First_Peter,
        Second_Peter,
        First_John,
        Second_John,
        Third_John,
        Jude,
        Revelation

    }
}
