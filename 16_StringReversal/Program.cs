using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_StringReversal
{
    //perhaps a good use for palindrome detection
    class Program
    {
        static void Main(string[] args)
        {
            //mirror string word
            string oneWord = "Zachary";
            string oneWordReversed = "";
            for (int i = 0; i < oneWord.Length; i++)
            {
                oneWordReversed += oneWord[(oneWord.Length - 1) - i];
            }
            Console.WriteLine("{0} >< {1}", oneWord, oneWordReversed);

            string sentence = "Hello, my name is Zachary John Jones";
            string sentenceReversedIndividually = "";
            //reverse each word in a non mirrored string

            //mirror string sentence
            string sentenceMirrored = "";
            string[] tempStringArrayHolder;
            tempStringArrayHolder = sentence.Split(' ');
            for (int i = 0; i < tempStringArrayHolder.Length; i++)
            {
                sentenceMirrored += tempStringArrayHolder[(tempStringArrayHolder.Length - 1) - i] + " ";
            }
            Console.WriteLine("{0} >< {1}", sentence, sentenceMirrored);

            //mirrored string, reverse each word
            string sentenceMirroredIndividually = "";

            Console.ReadKey();
        }
    }
}
