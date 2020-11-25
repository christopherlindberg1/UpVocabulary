using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures
{
    public class VocabularyManager
    {
        private readonly List<Vocabulary> _vocabularies;





        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        private List<Vocabulary> Vocabularies
        {
            get => _vocabularies;

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        "Vocabularies",
                        "Vocabularies cannot be null");
                }
            }
        }





        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public VocabularyManager()
        {
            Vocabularies = new List<Vocabulary>();
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private void FillWithSampleData()
        {

        }
    }
}
