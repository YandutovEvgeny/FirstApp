﻿//#define FIRST_HW
//#define SECOND_HW
//#define SWITCH_CALC
//#define IF_ELSE_CALC
//#define THIRD_HW
//#define FOURTH_HW
//#define FIFTH_HW
//#define SIXTH_HW
using System;

namespace HomeWorks
{
    class HomeWorks
    {
        static void ShowString(char character, uint number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }

        static int IndexOf(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element) return i;
            }
            return -1;
        }

        static int[] GetRandomArray(uint Length, int minValue, int maxValue)
        {
            int[] myArray = new int[Length];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }
            return myArray;
        }
        static void Main(string[] args)
        {
#if FIRST_HW
            //TODO: Напишите программу, вычисляющую среднее арифметическое двух чисел
            double firstValue, secondValue;

            Console.WriteLine("Введите число 1");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;
            Console.WriteLine("Среднее арифметическое двух чисел = " + result);

            //TODO: Напишите простой конвертер валют
            double UsdToRub = 107.56;
            double UsdToUah = 30.04;
            double USD;

            Console.WriteLine("Введите сумму в USD");
            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " USD в UAH = " + USD * UsdToUah + " UAH");
            Console.WriteLine(USD + " USD в RUB = " + USD * UsdToRub + " RUB"); 
#endif
#if SECOND_HW
            ulong inputNumber;

            Console.WriteLine("Введите число:");
            inputNumber = ulong.Parse(Console.ReadLine());

            if (inputNumber % 2 == 0) Console.WriteLine("Ваше число чётное!");
            else Console.WriteLine("Ваше число не чётное!"); 
#endif
#if SWITCH_CALC
            //TODO: Реализовать простой калькулятор при помощи конструкции switch
            while (true)    //Цикл для калькулятора
            {
                Console.Clear();    //Очищает консоль
                double firstNumber;     //Первое число
                double secondNumber;    //Второе число
                char sign;              //Знак операции

                try
                {
                    Console.WriteLine("Введите число 1:");
                    firstNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2:");
                    secondNumber = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число!");
                    Console.ReadLine();     //Очищает консоль
                    continue;
                }

                Console.WriteLine("Выберите знак, который хотите ввести: '+', '-', '*', '/'");
                sign = char.Parse(Console.ReadLine());
                
                switch (sign)
                {
                    case '+': Console.WriteLine(firstNumber + "+" + secondNumber + "=" + (firstNumber + secondNumber)); break;
                    case '-': Console.WriteLine(firstNumber + "-" + secondNumber + "=" + (firstNumber - secondNumber)); break;
                    case '*': Console.WriteLine(firstNumber + "*" + secondNumber + "=" + (firstNumber * secondNumber)); break;
                    case '/':
                        if (firstNumber == 0 || secondNumber == 0) Console.WriteLine(firstNumber + "/" + secondNumber + "=" + 0);
                        else Console.WriteLine(firstNumber + "/" + secondNumber + "=" + (firstNumber / secondNumber)); break;
                    default: Console.WriteLine("Ошибка 0: Неизвестная операция!"); break;
                }

                Console.ReadLine();
            }
#endif
#if IF_ELSE_CALC
            //TODO: Реализовать простой калькулятор при помощи конструкции if else
            double firstNumber;
            double secondNumber;
            char sign;
            Console.WriteLine("Введите арифметическое выражение:");
            string[] tokens = Console.ReadLine().Split();
            firstNumber = double.Parse(tokens[0]);
            sign = char.Parse(tokens[1]);
            secondNumber = double.Parse(tokens[2]);
            if (sign == '+') Console.WriteLine(firstNumber + "+" + secondNumber + "=" + (firstNumber + secondNumber));
            else if (sign == '-') Console.WriteLine(firstNumber + "-" + secondNumber + "=" + (firstNumber - secondNumber));
            else if (sign == '*') Console.WriteLine(firstNumber + "*" + secondNumber + "=" + (firstNumber * secondNumber));
            else if (sign == '/') Console.WriteLine(firstNumber + "/" + secondNumber + "=" + (firstNumber / secondNumber));
            else Console.WriteLine("noOperation"); 
#endif
#if THIRD_HW
            //TODO:Написать программу, которая подсчитывает кол-во и сумму чётных и нечётных целых чисел
            //в том диапазоне, котором укажет пользователь
            while (true)
            {
                Console.Clear();
                uint evenNumberCount = 0;    //Чётные числа
                uint oddNumberCount = 0;     //Нечётные числа
                int sumEven = 0;            //Сумма чётных чисел
                int sumOdd = 0;             //Сумма нечётных чисел
                //Диапазон вводимых данных:
                int currentValue;           //от
                int limitValue;             //до

                Console.WriteLine("Введите диапазон чисел в которых будет выполнятся программа:");
                try
                {
                    Console.WriteLine("Введите ОТ какого числа будет выполнятся программа:");
                    currentValue = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите ДО какого числа будет выполнятся программа:");
                    limitValue = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка: Напишите целые числа!");
                    Console.ReadLine();
                    continue;
                }

                while (currentValue <= limitValue)
                {
                    currentValue++;
                    Console.WriteLine(currentValue);
                    if (currentValue % 2 == 0)
                    {
                        evenNumberCount++;
                        sumEven += currentValue;
                    }
                    else
                    {
                        oddNumberCount++;
                        sumOdd += currentValue;
                    }
                }
                Console.WriteLine("Количество чётных чисел: " + evenNumberCount + ", сумма чётных чисел: " + sumEven);
                Console.WriteLine("Количество НЕчётных чисел: " + oddNumberCount + ", сумма НЕчётных чисел: " + sumOdd);

                Console.ReadLine();
            } 
#endif
#if FOURTH_HW
            //TODO: *       ****        *       ****
            //      **      ***        **        ***
            //      ***     **        ***         **
            //      ****    *        ****          *

            //First Triangle
            Console.Write("Введите размер треугольника: ");
            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");    //Позволяет не перносить строку, аналог cout << "...";
                }
                Console.WriteLine();    //Позволяет переносить строку, аналог cout << endl;
            }
            Console.WriteLine();

            //Second Triangle
            for (int i = 1; i <= size; i++)
            {
                for (int j = i; j <= size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Third Triangle
            for (int i = 1; i <= size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i <= size; i++)
            {
                //Устанавливает позицию курсора: 1 параметр - расстояние от левого края, 2 параметр - расстояние сверху
                Console.SetCursorPosition(size - i, i + 18);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //Fourth Triangle
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i <= size; i++)
            {

                Console.SetCursorPosition((i - 2) + 1, i + 30);
                for (int j = i; j <= size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine(); 
#endif
#if FIFTH_HW
            /*TODO: 1) Заполнить массив с клавиатуры
                        2) Вывести массив в обратном порядке
                        3) Найти сумму чётных чисел в массиве
                        4) Найти наименьшее число в массиве*/

            Console.Write("Введите количество элементов: ");
            int size = int.Parse(Console.ReadLine()); Console.WriteLine();
            int[] Array = new int[size];
            Random rand = new Random();

            for (int i = 0; i < Array.Length; i++)      //Заполняет массив случайными числами
            {
                Array[i] = rand.Next(100);
            }

            /*for (int i = 0; i < Array.Length; i++)      //Заполнение каждого элемента массива с клавиатуры
            {
                Console.Write($"Введите элемент массива под индексом {i}: ");
                Array[i] = int.Parse(Console.ReadLine()); 
            }*/
            Console.WriteLine();

            for (int i = 0; i < Array.Length; i++)      //Вывод массива на экран
            {
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine("  <- Массив с клавиатуры, да в случайном порядке");

            for (int i = Array.Length - 1; i >= 0; i--)    //Вывод массива с конца
            {
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine("  <- Массив с конца в начало");

            int sumEven = 0;
            for (int i = 0; i < Array.Length; i++)      //Сумма чётных чисел
            {
                if (Array[i] % 2 == 0) sumEven += Array[i];
            }
            Console.Write("Сумма чётных чисел в массиве: " + sumEven); Console.WriteLine();

            int minValue = Array[0];
            for (int i = 1; i < Array.Length; i++)      //Минимальное значение в массиве
            {
                if (Array[i] < minValue) minValue = Array[i];
            }
            Console.Write("Минимальное значение в массиве: " + minValue); Console.WriteLine();

#endif
#if SIXTH_HW
            /*TODO: 1.Написать функцию, который выводит на экран строку.
                        Символы из которых состоит строка и их количество вводятся пользователем.

                        2.Написать функцию для поиска индекса элемента массива (тип элементов в массиве - int),
                        метод должен вернуть индекс первого найденного элемента (если он будет найден).*/

            Console.Write("Введите символ, который хотите вывести на экран: ");
            char character = char.Parse(Console.ReadLine()); Console.WriteLine();

            Console.Write("Введите количество символов: ");
            uint number = uint.Parse(Console.ReadLine());
            
            ShowString(character, number);

            Console.Write("Введите элемент индекс которого хотите узнать : ");
            int element = int.Parse(Console.ReadLine()); Console.WriteLine();
            
            int[] myArray = GetRandomArray(10, -20, 10);
            Console.WriteLine( IndexOf(myArray, element) ); 
#endif

        }
        
    }
}