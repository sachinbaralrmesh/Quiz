using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Quiz
{
    internal class MyStorage
    {
        internal static void storeXml<T>(T data, string file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream stream;
            stream = new FileStream(file, FileMode.Create);
            serializer.Serialize(stream, data);
            stream.Close();
        }
        public static T readXml<T>(String file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    XmlSerializer xmlSer = new XmlSerializer(typeof(T));
                    return (T)xmlSer.Deserialize(sr);
                }
            }
            catch
            {
                return default(T);
            }
        }
    }
}
