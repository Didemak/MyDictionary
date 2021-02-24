using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        K[] _Karray;
        V[] _Varray;

        K[] _KtempArray;
        V[] _VtempArray;
        public MyDictionary()
        {
            _Karray = new K[0];
            _Varray = new V[0];
        }
        public void Add(K key, V value)
        {
            _KtempArray = _Karray;
            _VtempArray = _Varray;

            _Karray = new K[_Karray.Length + 1];
            _Varray = new V[_Varray.Length + 1];

            for (int i = 0; i < _KtempArray.Length; i++)
            {
                _Karray[i] = _KtempArray[i];
            }
            for (int i = 0; i < _VtempArray.Length; i++)
            {
                _Varray[i] = _VtempArray[i];
            }

            _Karray[_Karray.Length - 1] = key;
            _Varray[_Varray.Length - 1] = value;
        }
    }

}
