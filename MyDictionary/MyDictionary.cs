using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<K, T>
    {
        KeyValuePair<K, T>[] _items;
        

        public MyDictionary()
        {
            _items = new KeyValuePair<K, T>[0];
        }

        public void Add(K key, T value)
        {
            if (Control(key))
            {
                Configuration();
                _items[_items.Length - 1] = new KeyValuePair<K, T>(key, value);
            }
            else
            {
                Console.WriteLine("Please enter a valid key.");
            }

        }

        public void Print()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        private void Configuration()
        {
            KeyValuePair<K, T>[] _temp;
            _temp = _items;
            _items = new KeyValuePair<K, T>[_items.Length + 1];
            for (int i = 0; i < _temp.Length; i++)
            {
                _items[i] = _temp[i];
            }

        }

        private bool Control(K _Key)
        {
            bool control = true;
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Key.ToString() == _Key.ToString())
                {
                    control = false;
                }
            }
            return control;

        }

        

    }



}
