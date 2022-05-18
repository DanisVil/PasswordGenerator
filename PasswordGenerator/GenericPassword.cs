using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class GenericPassword
    {
        public static int Length { get; set; }
        public static bool WordOn { get; set; }
        public static bool SimilarChar { get; set; }
        public static bool AmbiguousChar { get; set; }
        public static bool IncludeSimbols { get; set; }
        public static bool IncludeNumbers { get; set; }
        public static bool LowerCase { get; set; }
        public static bool UpperCase { get; set; }

        private const string SIMILAR_CHARS = "il1Lo0O";
        private const string AMBIGUOUS_CHARS = "{}[]()/\\\'\"`~,;:.<>";
        private const int ASKII_MAX = 126;
        private static string[] SWEAR_WORDS = Properties.Resources.swear_words.Split('\r'); //матюки

        public static string GetPass()
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            int wordWeight = 0;
            int indexWord = 0;
            string word=null;
            if (WordOn)
            {
                word = GetWord(Length);
                indexWord = rnd.Next(0, Length - word.Length + 1);
                wordWeight = word.Length;
            }
            for (int i = 0; i < Length - wordWeight; i++)
            {
                char sym;
                do
                {
                    sym = (char)rnd.Next(ASKII_MAX + 1);

                } while (SymIsNotCorrect(sym));
                sb.Append(sym);
            }
            if (word != null)
            {
                sb.Insert(indexWord, word);
            }
            return sb.ToString();
        }
        private static bool SymIsNotCorrect(char sym)
        {
            bool isSymbol = char.IsPunctuation(sym) || char.IsSymbol(sym);
            bool symbolsOn = isSymbol && IncludeSimbols;
            bool digitOn = char.IsDigit(sym) && IncludeNumbers;
            bool lowerOn = char.IsLower(sym) && LowerCase;
            bool upperOn = char.IsUpper(sym) && UpperCase;
            bool character = digitOn || symbolsOn || lowerOn || upperOn;
            bool similarOn = SIMILAR_CHARS.Contains(sym) && SimilarChar;
            bool ambiguousOn = AMBIGUOUS_CHARS.Contains(sym) && AmbiguousChar;
            bool generalCondition = similarOn
                                    || ambiguousOn
                                    || char.IsWhiteSpace(sym)
                                    || !character;
            return generalCondition;
        }

        private static string GetWord(int length)
        {
            Random rnd = new Random();
            int maxLengthWord = rnd.Next(SWEAR_WORDS.Min(x => x.Trim().Length), length);
            string word = SWEAR_WORDS[rnd.Next(SWEAR_WORDS.Length)];
            while (word.Length > maxLengthWord)
            {
                word = SWEAR_WORDS[rnd.Next(SWEAR_WORDS.Length)];
            }
            return word;
        }
        
    }
}
