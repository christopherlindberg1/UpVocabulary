using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using AppFeatures;

namespace DataAccess
{
    public class Serializer
    {
        private static string _dataFolderPath;





        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        private static string DataFolderPath
        {
            get => _dataFolderPath;

            set
            {
                _dataFolderPath = value ??
                    throw new ArgumentNullException(
                        "DataFolderPath",
                        "DataFolderPath cannot be null.");
            }
        }

        public static void SaveVocabularyManager(VocabularyManager vocabularyManager)
        {
            string storageFolderPath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\App\DataAccess\Data\");
            string filePath = Path.Combine(storageFolderPath, @".\VocabularyManager.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(VocabularyManager));

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, vocabularyManager);
            }
        }
    }
}
