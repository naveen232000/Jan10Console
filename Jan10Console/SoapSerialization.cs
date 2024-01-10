using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace Jan10Console
{
    internal class SoapSerialization
    {
        public void SetValue()
        {
            Company company = new Company();
            company.id = 1;
            company.name = "NMC&co";
            company.description = "NMC Company offers ";
            FileStream fs = new FileStream(@"D:\Mphasis\Phase1 C#\10jan\SoapSerialization.txt", FileMode.Create, FileAccess.Write);
            SoapFormatter bf = new SoapFormatter();
            bf.Serialize(fs, company);
            fs.Close();
        }
        //Deserialize
        public void GetValue()
        {
            Company comp;
            SoapFormatter bf = new SoapFormatter();
            FileStream fs = new FileStream(@"D:\Mphasis\Phase1 C#\10jan\SoapSerialization.txt", FileMode.Open, FileAccess.Read);
            comp = (Company)bf.Deserialize(fs);
            Console.WriteLine(comp.id);
            Console.WriteLine(comp.name);

        }
    }
}
