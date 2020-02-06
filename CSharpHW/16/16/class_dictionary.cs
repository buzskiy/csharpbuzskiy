using System.Collections.Generic;
using System.Linq;

namespace _16
{
    public class Dictionary<T> where T : class
    {
        public List<DictionaryObject<T>> dictionary = new List<DictionaryObject<T>>();

        public void Add(T key, T value)
        {
            DictionaryObject<T> obj = new DictionaryObject<T>(key, value);
            dictionary.Add(obj);
        }
        public void Remove(T key)
        {
            
            foreach (DictionaryObject<T> obj in dictionary.ToList())
            {
                if (obj.Key.Equals(key))
                {
                    dictionary.Remove(obj);
                }
            }
            //var remove = dictionary.Find(i => i.Key == key); why does not this work?
            //dictionary.Where(i => i.Key == key).FirstOrDefault();

        }
    }

    public class DictionaryObject<T>
    {
        public T Key { get; set; }
        public T Value { get; set; }

        public DictionaryObject(T key, T value)
        {
            Key = key;
            Value = value;
        }
    }
}
