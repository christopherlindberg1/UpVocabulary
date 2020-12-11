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

        public static void XmlSerialize<T>(string filePath, T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                serializer.Serialize(streamWriter, obj);
            }
        }
    }
}
