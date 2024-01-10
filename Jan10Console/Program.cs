using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Jan10Console
{//Serializable
    [Serializable]
    public class Company
    {
        public int id;
        public string name;
        public string description;
    }
   
    internal class Program
    {
        public void SetValue() { 
        Company company = new Company();
            company.id = 1;
            company.name = "N&co";
            company.description = "Company Desc";
            FileStream fs = new FileStream(@"D:\Mphasis\Phase1 C#\10jan\seritest.txt",FileMode.Create,FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, company);
            fs.Close();
        }
        //Deserialize
        public void GetValue() {
            Company comp;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(@"D:\Mphasis\Phase1 C#\10jan\seritest.txt", FileMode.Open, FileAccess.Read);
            comp=(Company)bf.Deserialize(fs);
            Console.WriteLine(comp.id);
            Console.WriteLine(comp.name);

        }
        static void Main(string[] args)
        {
            Program n = new Program();
            n.SetValue();
            n.GetValue();
            SoapSerialization ss = new SoapSerialization();
            ss.SetValue();
            ss.GetValue();
            XmlSerialization xs = new XmlSerialization();
            xs.SetValue();
            xs.GetValue();

            JsonSerialization js=new JsonSerialization();
            js.CreateGetJson();
            Console.ReadLine();
        }
    }
}
