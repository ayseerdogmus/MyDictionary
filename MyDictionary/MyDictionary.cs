using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<V,K>
    {
        private V[] _value;
        private K[] _key;

        public MyDictionary()
        {
            _value = new V[0];
            _key = new K[0];
        }

        public void Add(V value, K key)
        {
           V[] _tempValue = _value;
           K[] _tempKey = _key;
            _value = new V[_value.Length + 1];
            _key = new K[_key.Length + 1];


            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
                _key[i] = _tempKey[i];
            }

            _value[_value.Length - 1] = value;
            _key[_key.Length - 1] = key;
        }

        public void List()
        {
            for (int i = 0; i < _value.Length; i++)
            {
                Console.WriteLine(_key[i]  + " : " + _value[i]);
            }
        }

    }
}

