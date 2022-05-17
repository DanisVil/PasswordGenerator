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
        private const int LENGTH = 10;
        private const bool WORD_ON = true;
        private const bool SIMILAR_CHAR = true;
        private const bool AMBIGUOUS_CHAR = true;
        private const bool INCLUDE_SIMBOLS = true;
        private const bool INCLUDE_NUMBERS = false;
        private const bool LOWERCASE = false;
        private const bool UPPERCASE = false;
        private const string SIMILAR_CHARS = "il1Lo0O";
        private const string AMBIGUOUS_CHARS = "{}[]()/\\\'\"`~,;:.<>";
        private const int ASKII_MAX = 126;

        public static string GetPass()
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            int wordWeight = 0;
            int indexWord = 0;
            string word=null;
            if (WORD_ON)
            {
                word = GetWord(4);
                indexWord = rnd.Next(0, LENGTH - word.Length + 1);
                wordWeight = word.Length;
            }
            for (int i = 0; i < LENGTH - wordWeight; i++)
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
            bool symbolsOn = isSymbol && INCLUDE_SIMBOLS;
            bool digitOn = char.IsDigit(sym) && INCLUDE_NUMBERS;
            bool lowerOn = char.IsLower(sym) && LOWERCASE;
            bool upperOn = char.IsUpper(sym) && UPPERCASE;
            bool character = digitOn || symbolsOn || lowerOn || upperOn;
            bool similarOn = SIMILAR_CHARS.Contains(sym) && SIMILAR_CHAR;
            bool ambiguousOn = AMBIGUOUS_CHARS.Contains(sym) && AMBIGUOUS_CHAR;
            bool generalCondition = similarOn
                                    || ambiguousOn
                                    || char.IsWhiteSpace(sym)
                                    || !character;
            return generalCondition;
        }
            
        private static string GetWord(int length)
        {
            string word = "fuck";
            //рандомно берет одно слово в зависимости от длины 
            return word;
        }
    }
}
