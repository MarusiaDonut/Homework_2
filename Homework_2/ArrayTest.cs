using System.Collections;
using System.Diagnostics;

namespace Homework_2
{
    internal class ArrayTest
    {
        public int num = 1000000;
        public Stopwatch stopWatch = new Stopwatch();
        public void ListArr()
        {
            List<int> charList = new List<int>();
            stopWatch.Start();
            for (int i = 0; i < num; i++)
            {
                charList.Add(i);
            }
            stopWatch.Stop();
            Console.WriteLine("Длительность заполнения коллекции List в милисекундах = " + stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            int found = charList.Find(item => item == 496753);
            stopWatch.Stop();
            Console.WriteLine("Длительность поиска элемента {0} в коллекции List в милисекундах = {1}", found,  stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            foreach (int j in charList)
            {
                if (j % 777 == 0)
                {
                    Console.Write("|" + j + "| ");
                }
            }
            stopWatch.Stop();
            Console.WriteLine("\nДлительность поиска элемента, который делится без остатка на 777 в коллекции List в милисекундах = {0}", stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();
            Console.WriteLine("\n");
        }

        public void ArrList()
        {
            ArrayList list = new ArrayList();
            stopWatch.Start();
            for (int i = 0; i < num; i++)
            {
                list.Add(i);
            }
            stopWatch.Stop();
            Console.WriteLine("Длительность заполнения коллекции ArrayList в милисекундах = " + stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            int found = list.IndexOf(496752);
            stopWatch.Stop();
            Console.WriteLine("Длительность поиска элемента {0} в коллекции ArrayList в милисекундах = {1}", found, stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            foreach (int j in list)
            {
                if (j % 777 == 0)
                {
                    Console.Write("|" + j + "| ");
                }
            }
            stopWatch.Stop();
            Console.WriteLine("\nДлительность поиска элемента, который делится без остатка на 777 в коллекции ArrayList в милисекундах = {0}", stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();
            Console.WriteLine("\n");
        }

        public void ArrLinkedList()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            stopWatch.Start();
            for (int i = 0; i < num; i++)
            {
                linkedList.AddLast(i);
            }
            stopWatch.Stop();
            Console.WriteLine("Длительность заполнения коллекции LinkedList в милисекундах = " + stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            LinkedListNode<int> found = linkedList.Find(496753);
            stopWatch.Stop();
            Console.WriteLine("Длительность поиска элемента {0} в коллекции LinkedList в милисекундах = {1}", found.Value, stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            foreach (int j in linkedList)
            {
                 if (j % 777 == 0)
                 {
                     Console.Write("|" + j + "| ");
                 }
            }
            stopWatch.Stop();
            Console.WriteLine("\nДлительность поиска элемента, который делится без остатка на 777 в коллекции LinkedList в милисекундах = {0}", stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();
            Console.WriteLine("\n");
        }
    }
}
