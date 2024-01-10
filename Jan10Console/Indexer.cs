using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan10Console
{
    public class SampleInd
    {
        public string[] str = new string[5];
        public string this[int indxNum]
        {
            get { return str[indxNum]; }
            set { str[indxNum] = value; }
        }
        internal class Indexer
        {
            static void Main(string[] args)
            {
                SampleInd sampleInd = new SampleInd();
                sampleInd[0] = "One";
                sampleInd[1] = "Two";
                sampleInd[2] = "Three";
                sampleInd[3] = "four";
                sampleInd[4] = "five";
                foreach(string i in sampleInd.str)
                {
                    Console.WriteLine(i);
                }
             Console.ReadLine();

            }
        }
    }
}
