using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class MedarbejderListe<Tkey>
    {
        private readonly Dictionary<Tkey, IHarAdresse> _collection = new();

        public void AddElement(Tkey key, IHarAdresse element)
        {
            if (_collection.ContainsKey(key))
            {
                throw new ArgumentException("Key already exists");
            } else
            _collection.Add(key, element);
        }

        public IHarAdresse GetElement(Tkey key)
        {
            if (_collection.ContainsKey(key))
            {
                return _collection[key];
            }
            else
            {
                throw new ArgumentException("Key does not exist");
            }
        }

        public int size()
        {
            return _collection.Count;
        }
        public void Print()
        {
            foreach (KeyValuePair<Tkey, IHarAdresse> kvp in _collection)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }

    }
}
