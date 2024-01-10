using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jan10Console
{
    internal class XmlSerialization
    {
        public void SetValue()
        {
            Company company = new Company();
            company.id = 1;
            company.name = "Xml Serialization & co";
            company.description = "Xml Serialization Company offers ";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Company));

            using (TextWriter txtWriter = new StreamWriter(@"D:\Mphasis\Phase1 C#\10jan\XmlSerialization.xml"))
            {
                xmlSerializer.Serialize(txtWriter, company);
            }

        }
        //Deserialize
        public void GetValue()
        {
           
            FileStream fs = new FileStream(@"D:\Mphasis\Phase1 C#\10jan\XmlSerialization.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer serializer = new XmlSerializer(typeof(Company));
            //Calling Deserialize() to deserialize data from the file
            Company comp = (Company)serializer.Deserialize(fs);

            Console.WriteLine(comp.id);
            Console.WriteLine(comp.name);

        }
    }
}
