using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProg
{
    internal class GenericCollectionsDemo
    {
        public void ListElements()
        {
            List<string> numbers = new List<string>();
            numbers.Add("hi");
            numbers.Add("20");
            numbers.Add("230");

            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Sort();
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Remove("230");
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void StackElements()
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(100);
            numbers.Push(287);
            numbers.Push(-100);
            numbers.Push(333);
            numbers.Push(8765);
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Sum());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Pop" + numbers.Pop());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Clear();
            Console.WriteLine("Pop" + numbers.Pop());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void QueueElements()
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(100);
            numbers.Enqueue(287);
            numbers.Enqueue(-100);
            numbers.Enqueue(333);
            numbers.Enqueue(8765);
            //Console.WriteLine(numbers.Average());
            //Console.WriteLine(numbers.Sum());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Pop" + numbers.Dequeue());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            //       numbers.Clear();
            Console.WriteLine("Pop" + numbers.Dequeue());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(numbers.First());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public void HashElements()
        {
            Dictionary<string, string> students =
                new Dictionary<string   , string>();
            students.Add("rno", "1001");
            students.Add("name", "XXX");
            foreach ( string k in students.Keys)
            { 
                Console.WriteLine(k + " : "
                    + students[k]);
            } 
        }
        public void SortedListElements()
        {
            SortedList<string, string> students =
                new SortedList<string, string>();
            students.Add("rno", "1001");
            students.Add("name", "XXX");
            foreach (string k in students.Keys)
            {
                Console.WriteLine(k + " : "
                    + students[k]);
            }
        }


    }
}
