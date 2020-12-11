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
                try
                {
                    serializer.Serialize(streamWriter, obj);
                }
                // Catch more specific exception than this
                catch (Exception ex)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public static T XmlDeserialize<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                try
                {
                    return (T)serializer.Deserialize(streamReader);
                }
                // Catch more specific exception than this
                catch (Exception ex)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
