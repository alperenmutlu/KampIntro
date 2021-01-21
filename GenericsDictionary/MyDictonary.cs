using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDictionary
{
    class MyDictonary<Tkey,Tvalue>
    {
        Tkey[] _keys;
        Tvalue[] _values;
        public MyDictonary()
        {
            _keys = new Tkey[0];
            _values = new Tvalue[0];

        }
        public void Add(Tkey tKey, Tvalue tValue)
        {
            Tkey[] _tempKeys = _keys;
            Tvalue[] _tempValues = _values;

            _keys = new Tkey[_keys.Length + 1];
            _values = new Tvalue[_values.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
                for (int j = 0; j < _tempValues.Length; j++)
                {
                    _values[i] = _tempValues[i];
                }
            }

            _keys[_keys.Length - 1] = tKey;
            _values[_values.Length - 1] = tValue;

        }

        public Tkey[] Key
        {
            get { return _keys; }
        }

        public Tvalue[] Values
        {
            get { return _values; }
        }

        public int Count_Key 
        {
            get { return _keys.Length; }
           
        }

        public int Count_Value
        {
            get { return _values.Length; }
        }
        
    }
}
