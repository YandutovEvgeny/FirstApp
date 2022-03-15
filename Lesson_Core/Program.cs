using System;

namespace Lesson_Core
{
    /*
        Индексы и диапазоны
     */
    class Program
    {
        static void Main(string[] args)
        {

            //int[] myArray = { 2, 10, 5, 6, 77, 89, 1414 };
            //Console.WriteLine(myArray[^1]);     //^ - позволяет получить элементы с конца
            //^1 - означает получить первый элемент с конца

            //Задача диапазона извлечь один диапазон элементов массива в другой
            //int[] myArray2 = myArray[5..];   //Начало диапазона .. Конец диапазона 

            //int[] myArray = { 2, 10, 5, 6, 77, 89, 1414 };
            /*Index myIndex = new Index(3,true);     //^3
            Console.WriteLine(myArray[myIndex]);
            Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");*/

            //Range myRange = new Range(1,4);     //1..4
            //int[] myArray2 = myArray[^4..^1];

            string str = "Hello World! =)";

            Console.WriteLine(str[6..11]);
        }
    }
}
