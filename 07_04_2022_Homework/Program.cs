using _07_04_2022_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_04_2022_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyList<int> myList = new MyList<int>(1, 2, 3, 4, 5);
            //Console.WriteLine(myList._count);
            //Console.WriteLine();
            //Console.WriteLine();
            //for (int i = 0; i < myList._count; i++) Console.WriteLine(myList[i]);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //myList.Remove(3);
            //for (int i = 0; i < myList._count; i++) Console.WriteLine(myList[i]);
            //myList.Remove(4);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //for (int i = 0; i < myList._count; i++) Console.WriteLine(myList[i]);
            //myList.Remove(7);
            MyList<char> letters = new MyList<char>();
            letters.AddItem('a');
            letters.AddItem('b'); 
            letters.AddItem('c');
            letters.AddItem('d');
            letters.AddItem('f');
            letters.AddItem('g');
            for (int i = 0; i < letters._count; i++) Console.Write($"{letters[i]} ");
            Console.ReadLine();
        }
    }
}
