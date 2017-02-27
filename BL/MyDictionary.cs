using System;
using System.Collections.Generic;

namespace BL
{
    public class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>
    {
        public List<TKey> Keys { get; private set; }
        public List<TValue> Values { get; private set; }

        public int Count => Keys.Count;

        public TValue this[TKey key]
        {
            get { return Values[Keys.IndexOf(key)]; }
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                Add(key, value);
            }
        }

        public MyDictionary()
        {
            Keys = new List<TKey>();
            Values = new List<TValue>();
        }

        public bool IsEmpty() => Keys.Count == 0;

        public void Clear()
        {
            Keys = new List<TKey>();
            Values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            if (!ContainsKey(key))
            {
                Keys.Add(key);
                Values.Add(value);
            }
            else
            {
                var tmpKeyIndex = Keys.IndexOf(key);
                Values[tmpKeyIndex] = value;
            }
        }

        public void Remove(TKey key)
        {
            if (ContainsKey(key))
            {
                var tmpKeyIndex = Keys.IndexOf(key);
                Keys.Remove(key);
                Values.RemoveAt(tmpKeyIndex);
            }
        }

        public bool ContainsKey(TKey key) => Keys.Contains(key);
    }
}