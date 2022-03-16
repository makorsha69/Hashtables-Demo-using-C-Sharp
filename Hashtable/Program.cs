using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HT
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable h=new Hashtable();
            h.Add(12345, "A");
            h.Add(65478, "B");
            h.Add(78965, "C");
            h.Add(45632, "D");
            foreach(DictionaryEntry d in h)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }
        }
    }
}
