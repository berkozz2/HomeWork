using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryHomeWork
{
    class MyDictionary<Sayi, Isim>
    {
        
        Sayi[] _number;
        Sayi[] _tempNumber;
        Isim[] _items;
        Isim[] _tempItems;

        //constructor
        public MyDictionary()
        {
            _number = new Sayi[0];
            _items = new Isim[0];
        }

        public void Add(Sayi number, Isim items)
        {
            _tempNumber = _number;
            _tempItems = _items;
            _number = new Sayi[_number.Length + 1];
            _items = new Isim[_items.Length + 1];

            for (int i = 0; i < _tempItems.Length; i++)
            {
                _items[i] = _tempItems[i];
            }

            _items[_items.Length - 1] = items;
        }


        public int Count
        {
            get { return _items.Length; }
        }


    }
}
