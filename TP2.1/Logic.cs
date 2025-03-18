using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2._1
{
    public class Logic
    {
        private string sentence;

        public Logic(string sentence)
        {
            this.sentence = sentence;
        }

        public double LetterPercentage()
        {
            int letterCount = 0;
            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                }
            }
            return sentence.Length > 0 ? (letterCount / (double)sentence.Length) * 100 : 0;
        }
    }
}