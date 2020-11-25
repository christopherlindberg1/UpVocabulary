using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures
{
    public class Vocabulary
    {
        private string _name;
        private readonly string[] _languages = new string[2];
        private readonly List<Word> _words;




        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name", "Name cannot be null");
                }

                _name = value;
            }
        }


    }
}
