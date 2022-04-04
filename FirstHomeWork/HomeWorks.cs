//#define FIRST_HW
//#define SECOND_HW
//#define SWITCH_CALC
//#define IF_ELSE_CALC
//#define THIRD_HW
//#define FOURTH_HW
//#define FIFTH_HW
//#define SIXTH_HW
//#define SEVENTH_HW
//#define EIGHTH_HW
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
        //6HW
        static int IndexOf(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element) return i;
            }
            return -1;
        }
        //6HW
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
        //7HW
        /*static void ShowArray<T>(ref T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }
        static void Resize<T>(ref T[] array, ref int numberOfElements) //generic - 
        {
            T[] newArray = new T[numberOfElements];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
                newArray[i] = array[i];
            array = newArray;
        }
        static void PushFront(ref int[] array, int addElement)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                newArray[i + 1] = array[i];
            }
            newArray[0] = addElement;
            array = newArray;
        }
        static void PushBack(ref int[] array, int addElement)
        {
            Insert(ref array, addElement, array.Length);
        }
        static void Insert(ref int[] array, int addElement, int insertIndex)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < insertIndex; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = insertIndex; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            newArray[insertIndex] = addElement;
            array = newArray;
        }
        static void Pop_front(ref int[] array)
        {
            Erase(ref array, 0);
        }
        static void Pop_back(ref int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        static void Erase(ref int[] array, int eraseIndex)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < eraseIndex; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = eraseIndex; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }
            array = newArray;
        }*/
        //8HW
        static void ShowArray(int[] array, int count = 0)
        {
            /*if (count == array.Length) return;
            Console.Write(array[count++] + "\t");
            ShowArray(ref array);*/
            if (count < array.Length)
            {
                Console.Write(array[count] + "\t");
                ShowArray(array, count + 1);
            }
        }

        static int Sum(int[] array, int count = 0)
        {
            /*if (count == array.Length) return 0;
            sum += array[count++];
            Sum(array);
            return sum;*/
            if (count >= array.Length) return 0;
            return array[count] + Sum(array, count + 1);
        }

        static ulong NumberSum(ulong number)
        {
            if (number < 10) return number;
            return number % 10 + NumberSum(number / 10);
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
#if SEVENTH_HW
            /*TODO: DONE 1)Написать метод Resize изменяющий кол-во элементов массива
                    DONE 2)Написать методы для добавления элемента в начало массива, в конец и по указанному индексу
                    DONE 3)Написать методы для удаления элемента с начала массива, с конца и по указанному индексу*/

            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();

            /*int numberOfElements = 0;
            try
            {
                Console.WriteLine("Введите число для изменения массива: ");
                numberOfElements = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка! Введите положительное число!");
                return;
            }
            Resize(ref array, ref numberOfElements);
            ShowArray(ref array);*/
            
            int addElement = 0;
            int insertIndex = 0;
            Console.WriteLine("Введите элемент, который хотите добавить: ");
            addElement = int.Parse(Console.ReadLine());

            Console.WriteLine("Добавление в начало:");
            PushFront(ref array, addElement); 
            ShowArray(ref array);

            Console.WriteLine("Добавление в конец:");
            PushBack(ref array, addElement);  
            ShowArray(ref array);
            
            Console.WriteLine("Введите индекс, куда хотите вставить элемент: ");
            Console.WriteLine("Добавление по индексу:");
            insertIndex = int.Parse(Console.ReadLine());
            Insert(ref array, addElement, insertIndex);    
            ShowArray(ref array);
            
            Console.WriteLine("Удаление с начала:");
            Pop_front(ref array);
            ShowArray(ref array);

            Console.WriteLine("Удаление с конца:");
            Pop_back(ref array);
            ShowArray(ref array);

            Console.WriteLine("Введите индекс, который хотите удалить: ");
            Console.WriteLine("Удаление с конца:");
            int eraseIndex = int.Parse(Console.ReadLine());
            Erase(ref array, eraseIndex);
            ShowArray(ref array);
#endif
#if EIGHTH_HW
            /*TODO: DONE 1)Реализовать вывод массива с помощью рекурсии
                    DONE 2)Найти сумму элементов массива с помощью рекурсии
                    DONE 3)Найти сумму цифр числа с помощью рекурсии 467 = 17*/
            int[] array = new int[5];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            //int count = 0;
            //int sum = 0;
            ulong result = 0;

            ShowArray(array);
            Console.WriteLine();
            Console.WriteLine("Сумма элементов массива: ");
            Console.WriteLine(Sum(array));
            
            ulong number = 0;
                try
                {
                    Console.WriteLine("Введите целое число: ");
                    number = ulong.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный ввод! Введите целое число!");
                    return;
                } 

            result = NumberSum(number);
            Console.WriteLine($"Сумма числа {number} = {result}");

#endif
        }
        
    }
}