using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSample.DictionarySamples
{
    public class DictionarySample
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public void Add(string key, string value)
        { 
            if (!dictionary.ContainsKey(key))
                dictionary[key] = value; 

            dictionary.Add(key, value);
        }
        public string Get(string key)
            => dictionary[key];
        public void PrintAll()
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine($"value of {item.Key} is  : {item.Value}");
            }
        }
        
    }
}
