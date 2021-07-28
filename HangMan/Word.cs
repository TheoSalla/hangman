using System;
using System.Collections.Generic;
using System.Text;

namespace HangMan
{
    class Word
    {

        public string word { get; set; }
        private List<string> words;

        public Word()
        {

            words = new List<string>();
            generateWord();    
        }

        private void generateWord()
        {
            words.Add("Sega");
            words.Add("Apple");
            words.Add("Microsoft");
            words.Add("IBM");
            words.Add("Atari");
            words.Add("Nintendo");

            Random rng = new Random();
            int n = words.Count;
            int num = rng.Next(n);

            word = words[num];
           
        }

 


    }
}
