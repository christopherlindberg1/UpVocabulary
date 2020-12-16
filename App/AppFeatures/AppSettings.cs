using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;



namespace AppFeatures
{
    [Serializable()]
    public class AppSettings : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        
    }
}
