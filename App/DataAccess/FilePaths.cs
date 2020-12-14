using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataAccess
{
    public abstract class FilePaths
    {
        private static string DataStorageFolder
        {
            get
            {
                return Path.GetFullPath(
                    Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\DataAccess\Data"));
            }
        }

        public static string VocabularyManagerFilePath
        {
            get
            {
                return Path.GetFullPath(
                    Path.Combine(DataStorageFolder, @".\VocabularyManager.xml"));
            }
        }
    }
}
