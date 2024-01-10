using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Jan10Console
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    internal class JsonSerialization
    {
        public void CreateGetJson() {
            Employee emp = new Employee {
                Id = 101,
                Name="Naveen",
                Address="TN"
        };
            string fname = @"D:\Mphasis\Phase1 C#\10jan\JsonSerialization.json";
            string json=JsonSerializer.Serialize(emp);
            File.WriteAllText(fname, json);
            Console.WriteLine(File.ReadAllText(fname));
     

        }
    }
}
