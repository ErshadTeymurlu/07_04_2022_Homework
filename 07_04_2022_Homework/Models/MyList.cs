using _07_04_2022_Homework.Utilies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_04_2022_Homework.Models
{
    class MyList<T>
    {
        private T[] _arr;
        public int _count;
        //public int Count { get; }
        public int Capacity { get; set; } = 1;
        public MyList()
        {
            _arr = new T[Capacity];
            _count = 0;
        }
        public MyList(int capacity)
        {
            Capacity = capacity;
            _arr = new T[Capacity];
            _count = 0;
        }
        public MyList(params T[] elements)
        {
            Capacity = elements.Length;
            _arr = new T[Capacity];
            _count = elements.Length;
            _arr = elements;
        }
        public T this[int index]
        {
            get
            {
                return _arr[index];
            }
            set
            {
                _arr[index] = value;
            }
        }
        private void Resize(ref T[] arr, int length)
        {
            if (_count == Capacity)
            {
                Capacity = Capacity * 2;
                T[] newArr = new T[length];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == newArr.Length) break;
                    newArr[i] = arr[i];
                }
                arr = newArr;
            }
        }
        public void AddItem(T element)
        {
            Resize(ref _arr, _arr.Length+1);
            _arr[_arr.Length - 1] = element;
            _count++;
        }
        public void AddItems(params T[] elements)
        {
            Resize(ref _arr, elements.Length + 1);
            _arr = elements;
            _count += elements.Length;
        }
        public void Remove(T t)
        {
            int i = 0;
            for (; i < _arr.Length; i++)
            {
                if (t.Equals(_arr[i])) 
                {
                    break;
                }
                else if (i == _arr.Length -1 && t.Equals(_arr[i]) == false) throw new NotFoundException("Given element doesn't exist in the list.");
            }
            for (int j = i; j < _arr.Length - 1; j++)
            {
                _arr[j] = _arr[j + 1];
            }
            Resize(ref _arr, _arr.Length - 1);
            _count--;
        }
    }
}
