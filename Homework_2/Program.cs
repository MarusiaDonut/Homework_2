using Homework_2;

namespace Homework2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayTest arrayTest = new ArrayTest();
            int number = 3;
            for (int i = 0; i <= number; i++)
            {
                switch (i)
                {
                    case 1:
                        arrayTest.ArrLinkedList();
                        break;
                    case 2:
                        arrayTest.ArrList();
                        break;
                    case 3:
                        arrayTest.ListArr();
                        break;
                }
            }
            
        }
    }
}
