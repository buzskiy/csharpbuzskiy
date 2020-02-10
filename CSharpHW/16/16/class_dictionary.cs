using System.Collections.Generic;

namespace _16
{
    public class Dictionary<T>
    {
        public List<DictionaryObject<T>> dictionary = new List<DictionaryObject<T>>();

        public void Add(T key, T value)
        {
            DictionaryObject<T> obj = new DictionaryObject<T>(key, value);
            dictionary.Add(obj);
        }
        public void Remove(T key)
        {
            var elementToRemove = dictionary.Find(i => i.Key.Equals(key));
            dictionary.Remove(elementToRemove);
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
