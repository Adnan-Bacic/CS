using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections; //arraylists
using System.Runtime.Serialization.Formatters.Binary; //for binary
using System.IO; //for filestream

using System.Xml.Serialization; //xml

using System.Web.Script.Serialization; //json

namespace Serialization
{
    public class FileUtility
    {
        //binary write
        public static void WriteFile(ArrayList a, string filename)
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
        public static ArrayList ReadFile(string filename)
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

        //xml write
        public static void WriteCatXML(ArrayList a, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            XmlSerializer xmlser = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Cat), typeof(Chip) });
            xmlser.Serialize(fs, a);
            fs.Close();
        }
        //xml read
        public static ArrayList ReadCatXML(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            XmlSerializer xmlser = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Cat), typeof(Chip) });
            //deserialize
            ArrayList a = (ArrayList)xmlser.Deserialize(fs);
            fs.Close();
            return a;
        }

        //json old school write
        public static void WriteJSONOldSchool(ArrayList a, string filename)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer(new SimpleTypeResolver());
            string json = jss.Serialize(a);
            File.WriteAllText(filename, json);
        }

        //json old school read
        public static ArrayList ReadJSONOldSchool(string filename)
        {
            string json = File.ReadAllText(filename);
            JavaScriptSerializer jss = new JavaScriptSerializer(new SimpleTypeResolver());
            ArrayList a = jss.Deserialize < ArrayList >(json);
            return a;
        }

        //json write
        public static void WriteJSON(List<Cat> a, string filename)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string json = jss.Serialize(a);
            File.WriteAllText(filename, json);
        }
        //json read
        public static List<Cat> ReadJSON(string filename)
        {
            string json = File.ReadAllText(filename);
            JavaScriptSerializer jss = new JavaScriptSerializer();
            List<Cat> a = jss.Deserialize<List<Cat>>(json);
            return a;
        }
    }
}