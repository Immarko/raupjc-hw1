using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace raupjc_hw1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IntegerList lista = new IntegerList();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);

            lista.RemoveAt(0);
            lista.Remove(5);
            
            Console.WriteLine(lista.Count);
            Console.WriteLine(lista.Remove(100));
            //Console.WriteLine(lista.RemoveAt(5));
            
            lista.Clear();
            Console.WriteLine(lista.Count);

        }
    }
}