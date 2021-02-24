using MyDictionary;
using System;
using System.Collections.Generic;

namespace IDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> adetUrun = new MyDictionary<int, string>();
            adetUrun.Add(2, "Pantolon");
            adetUrun.Add(3, "Elbise");
            adetUrun.Add(5, "Etek");
            adetUrun.Add(7, "Hırka");

        }
    }

}
