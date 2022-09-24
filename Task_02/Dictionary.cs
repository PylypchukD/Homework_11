using System.Collections.Generic;

namespace Task_02
{
    internal class Dictionary<TKey, TValue>
    {
        private List<TKey> keys;
        private List<TValue> values;

        public Dictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }

        public int Lenght
        {
            get
            {
                return keys.Count;
            }
        }

        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public string this[int index]
        {
            get
            {
                return $"{keys[index]} {values[index]}";
            }
        }
        public string this[TKey key]
        {
            get
            {
                for (int i = 0; i < keys.Count; i++)
                {
                    if ((string)(object)keys[i] == (string)(object)key)
                    {
                        return (string)(object)values[i];
                    }
                }
                return "Элемент не найден";
            }
        }

    }
}
