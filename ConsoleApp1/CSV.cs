using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;

namespace ConsoleApp1
{
    public class CSV
    {
        public ListDictionary ReadCSV()
        {
            var list = new ListDictionary();
            list.Add("Thisiskey1","ThisisValue1");
            list.Add("Thisiskey2", "ThisisValue2");
            list.Add("Thisiskey3", "ThisisValue3");
            return list;
        }
    }
}