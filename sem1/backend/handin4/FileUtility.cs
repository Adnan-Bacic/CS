using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections; //arraylist

using System.Xml.Serialization; //xml

using System.IO; //for filestream

using System.Runtime.Serialization.Formatters.Binary; //for binar

namespace handin4
{
    public class FileUtility
    {
        //save xml
        public static void CreateXML(ArrayList a, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            XmlSerializer xmlser = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Person), typeof(Keycard) });
            xmlser.Serialize(fs, a);
            fs.Close();
        }

        //read xml
        public static ArrayList ReadXML(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            XmlSerializer xmlser = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Person), typeof(Keycard) });
            //deserialize
            ArrayList a = (ArrayList)xmlser.Deserialize(fs);
            fs.Close();
            return a;
        }

        //handin5

        //binary write
        public static void WriteBinary(ArrayList a, string filename)
        {
            //create file, write file, who has access to see the file
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            //creating formatter
            BinaryFormatter bf = new BinaryFormatter();
            //serializes the filestream
            bf.Serialize(fs, a);
            //close the filestream
            fs.Close();
        }

        //binary read
        public static ArrayList ReadBinary(string filename)
        {
            //opens file, reads file, who has access to see the file
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            //creating formatter
            BinaryFormatter bf = new BinaryFormatter();
            //adding it to the arraylist and deserializing filestream
            ArrayList a = (ArrayList)bf.Deserialize(fs);
            //close the filestream
            fs.Close();
            //returns the arraylist
            return a;
        }
    }
}