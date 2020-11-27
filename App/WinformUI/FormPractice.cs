using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI
{
    public partial class FormPractice : Form
    {
        private Queue<string> _lastUsedWords;





        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        private Queue<string> LastUsedWords
        {
            get => _lastUsedWords;
        }





        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public FormPractice()
        {
            InitializeComponent();
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private bool LastUsedWordsContains(string word)
        {
            return LastUsedWords.Contains(word);
        }

        /// <summary>
        ///   Adds a word to the queue. Dequeues the word at the beginning of
        ///   the queue if there was three words already.
        /// </summary>
        /// <param name="word">Word to add to the queue</param>
        private void AddWordToLastUsedWords(string word)
        {
            if (LastUsedWords.Count == 3)
            {
                LastUsedWords.Dequeue();
            }

            LastUsedWords.Enqueue(word);
        }
    }
}
