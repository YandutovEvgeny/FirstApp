//#define VARIABLES
//#define INPUT_WITH_KEYBOARD
//#define CONVERTATION_OF_STRING
//#define ARIFMETICAL_OPERATORS
//#define COMPAISON_OPERATORS
//#define IF_ELSE_CONSTRUCTION
//#define LOGICAL_OPERATORS
//#define SWITCH
//#define WHILE_DO_WHILE
//#define FOR
//#define BREAK_CONTINUE
//#define NESTED_LOOPS
//#define TERNARY_OPERATOR
//#define ARRAY
//#define INDEX_AND_RANGE
//#define MULTIPLE_ARRAY
//#define FUNCTIONS_METHODS
//#define FUNCTION_OVERLOADING
//#define VALUETYPES_REFERENCETYPE
//#define NULL_NULLUNIT
//#define KEYWORDS_REF_OUT_IN_PARAMS
//#define NAMED_DEFAULT_PARAMETERS
//#define RECURSION
//#define TYPE_CONVERSION
//#define ARIFMETICAL_OVERLOAD_CHECKED_UNCHECKED
//#define NULLABLE_TYPES
//#define KEYWORD_VAR
//#define ENUM
//#define OOP_CLASS_OBJECT
//#define OOP_METHODS
//#define PUBLIC_PRIVATE_INCAPSULATION
//#define CONSTRUCTOR_DEFAULT_CONSTRUCTOR
//#define KEYWORD_THIS
//#define PROPERTIES
//#define STATIC_CLASS
//#define EXTENSION_METHODS
//#define KEYWORD_PARTIAL
//#define CONST_READONLY
//#define SYNTACS_OBJECT_INITIALIZE
//#define INHARITANCE
//#define POLYMORPHISM
//#define ABSTRACT_CLASS
#define INTERFACES

using System;
using System.Reflection;
using Lesson_MyExtensions;
using Lesson2_MyExtensions;
using Lesson_2;

namespace FirstApp      //Пространство имён System
{

    class FirstApp
    {
        // Три слэша(///) перед методом или классом позволяет добавить описание методу или классу
        /// <summary>
        /// Возвращает сумму двух целых чисел
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        static int Addition(int value1, int value2)
        {
            return value1 + value2;
        }
        static double Addition(double value1, double value2)
        {
            return value1 + value2;
        }
        static int Addition(int value1, int value2, int value3)
        {
            return value1 + value2 + value3;
        }
        static void PrintLine()
        {
            Console.WriteLine("Метод PrintLine был вызван!");
        }
        static void PrintResult(int result)
        {
            Console.WriteLine("Результат сложения: " + result);
        }
        //ref
        static void Foo(ref int a)
        {
            a = -5;
        }
        static void Bar(int[] arr)
        {
            arr[0] = 15;
            arr[3] = 30;
        }
        static ref int Func(int[] arr)
        {
            return ref arr[0];
        }
        //out
        static void Foo1(ref int value)
        {
            Console.WriteLine(value);
        }
        static void Bar1(out int value)
        {
            value = 5;
            Console.WriteLine(value);
        }
        //in
        static void Foo2(in int value)
        {
            Console.WriteLine(value);
            //value = 10;
        }
        //params
        static int Sum(string message, params int[] parameters)
        {
            int result = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }
            return result;
        }
        static int Sum(params int[] parameters)
        {
            int result = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }
            return result;
        }

        //NAMED_DEFAULT_PARAMETERS
        static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;
            if (enableLogging)
            {
                Console.WriteLine("Значение переменной а = " + a);
                Console.WriteLine("Значение переменной b = " + b);
                Console.WriteLine("Результат сложения: " + result);
            }
            return result;
        }
        //Recursion
        static void Foo(int i)
        {
            Console.WriteLine(i);
            if (i >= 3) return;
            i++;
            Foo(i); //<- Рекурсия
        }
        static DayOfWeek nextDay(DayOfWeek day)
        {
            if (day < DayOfWeek.Sunday)
                return day + 1;
            return DayOfWeek.Monday;
        }
        enum DayOfWeek : byte   //Таким образом можно дать понять компилятору, что тип данных
                                //в enum byte, а не int, как установлено по умолчанию
        {
            //Если явно не указать значение каждого перечисления, счёт начинается с 0
            Monday,     //0
            Tuesday,    //1
            Wednesday,  //2...
            Thursday,
            Friday,
            Saturday,
            Sunday      //...6
        }

        enum Color
        {
            White,
            Red,
            Green,
            Blue,
            Orange
        }


        static void Main(string[] args)
        {
#if VARIABLES
            Console.WriteLine("Hello World!");
            Console.WriteLine("Привет Мир!");

            //Тип_данных имя_перeменной;
            int first, second;
            first = 7;
            second = 99;
            Console.WriteLine(first);
            Console.WriteLine(second);

            double a = 1.33;
            Console.WriteLine(a);

            string A = "C# the best!";
            Console.WriteLine(A);
            A = "C# is large!";
            Console.WriteLine(A); 
#endif
#if INPUT_WITH_KEYBOARD
            Console.WriteLine("Введите ваше имя:");
            string data;
            data = Console.ReadLine();  //Ввод данных с клавиатуры

            Console.WriteLine("Привет " + data + "!"); 
#endif
#if CONVERTATION_OF_STRING
            /*string str;
                int a, b;

                Console.WriteLine("Введите число 1:");
                str = Console.ReadLine();                  //Вводим данные с клавиатуры
                a = Convert.ToInt32(str);                  //Конвертируем строку str в 4 байтовый int

                Console.WriteLine("Введите число 2:");
                str = Console.ReadLine();                   
                b = Convert.ToInt32(str);                   

                int result = a + b;
                Console.WriteLine("Сумма введённых вами данных = " + result);*/

            string str = "1.9";
            //Позволяет установить разделитель в дробных числах:
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            double a = Convert.ToDouble(str, numberFormatInfo);     //Конвертация классом Convert
            Console.WriteLine(a); 
            /*string str = "5.9";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            double a = double.Parse(str, numberFormatInfo);     //Конвертация методом Parse()
            Console.WriteLine(a + a);*/

            /*string str = "5,9";
             try
             {
                 double a = double.Parse(str);
                 Console.WriteLine("Успешная конвертация!");
             }
             catch(Exception)
             {
                 Console.WriteLine("Ошибка при конвертации!");
             }*/

            string str = "1";
            int a;
            bool result = int.TryParse(str, out a);     //Конвертация методом TryParse(), который не бросает ичключения
            if (result) Console.WriteLine("Операция успешна, значение = " + a);
            else Console.WriteLine("Не удалось конвертировать!");
#endif
#if ARIFMETICAL_OPERATORS
            /*int a = 10;
                int b = 3;
                int c = 5;

                double result = (a * b) / c;
                Console.WriteLine(result);*/

            //Среднее арифметическое:
            int first_digit;
            //int second_digit;
            string str;

            Console.WriteLine("Введите первое число:");
            str = Console.ReadLine();
            first_digit = Convert.ToInt32(str);

            Console.WriteLine("Введите второе число:");
            str = Console.ReadLine();
            int second_digit = int.Parse(str);

            double result = (first_digit + second_digit) / 2;
            Console.WriteLine("Среднее арифметическое двух чисел: " + result);

            //Сумма и произведение 3 чисел:
            string str1;

            Console.WriteLine("Enter first number:");
            str1 = Console.ReadLine();
            int first_digit1 = int.Parse(str1);

            Console.WriteLine("Enter second number:");
            str1 = Console.ReadLine();
            int second_digit1 = int.Parse(str1);

            Console.WriteLine("Enter third number:");
            str1 = Console.ReadLine();
            int third_digit1 = int.Parse(str1);

            int result_of_addition = first_digit1 + second_digit1 + third_digit1;
            int result_of_multiplication = first_digit1 * second_digit1 * third_digit1;

            Console.WriteLine("Result of addition: " + result_of_addition);
            Console.WriteLine("Result of multiplication: " + result_of_multiplication);

            //Конвертер валют:
            string val_str;
            const double dollar = 91.7457;
            //const double rouble = 0.0109;
            Console.WriteLine("I have");
            val_str = Console.ReadLine();
            int my_dollars = int.Parse(val_str);
            Console.WriteLine("dollars");

            double result_DollToRub = my_dollars * dollar;
            Console.WriteLine("I take " + result_DollToRub + " roubles"); 
#endif
#if COMPAISON_OPERATORS
            int a = 5;
            int b = 4;
            //bool result = a != b;          
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b); 
#endif
#if IF_ELSE_CONSTRUCTION
            bool isInfected = true;

            if (isInfected) Console.WriteLine("Персонаж инфицирован!");
            else Console.WriteLine("Персонаж здоров!");

            int a;
            a = int.Parse(Console.ReadLine());

            if (a == 5) Console.WriteLine("а равна 5");
            else Console.WriteLine("а не равна пяти"); 
#endif
#if LOGICAL_OPERATORS
            bool isInfected = false;

            if (!isInfected) Console.WriteLine("Персонаж здоров!");
            else Console.WriteLine("Персонаж инфицирован!");

            uint fanSpeed = 0;
            bool isHighTemperature = false;
            bool hasNoCooling = fanSpeed <= 0;

            if (isHighTemperature && hasNoCooling)
                Console.WriteLine("Угроза повреждения процессора!");
            else if (isHighTemperature || hasNoCooling)
                Console.WriteLine("Оборудование не исправно!");
            else Console.WriteLine("Система работает в штатном режиме!"); 
#endif
#if SWITCH
            /*int a = int.Parse(Console.ReadLine());

                switch(a)
                {
                    case 1: Console.WriteLine("Вы ввели число 1"); break;
                    case 2: Console.WriteLine("Вы ввели число 2"); break;
                    default: Console.WriteLine("И не 1, и не 2"); break;
                }*/

            /* string str = Console.ReadLine();

             switch(str)
             {
                 case "+": Console.WriteLine("Вы ввели плюс"); break;
                 case "-": Console.WriteLine("Вы ввели минус"); break;
                 default: Console.WriteLine("Вы ввели неизвестный символ"); break;
             }*/

            ConsoleKey consoleKey = Console.ReadKey().Key;  //Перечисление каждой клавиши на клавиатуре(enum)

            //При вызове switch позволяет реализовать код для каждой клавиши на клавиатуре  
#endif
#if WHILE_DO_WHILE
            int i = 0;
            int limit = int.Parse(Console.ReadLine());
            /*while (i < limit)
            {
                Console.WriteLine("Выполняем действие " + i + " раз");
                i++;
                //Thread.Sleep(1000);
            }*/

            do
            {
                i++;
                Console.WriteLine("Выполняем действие " + i + " раз(а)");
            } while (i < limit);

#endif
#if FOR
            /*int limit = int.Parse(Console.ReadLine());
               for (int i = 0; i < limit; i++)
               {
                   Console.WriteLine(i);
               }*/
            /* int i = 0;
             for (; i < 3; i++)
             {
                 Console.WriteLine("for_1: " + i);
             }
             for (; i < 5; i++)
             {
                 Console.WriteLine("for_2: " + i);
             }*/

            /*for (int i = 0, j = 5; i < 10 && j < 15 ; i++, j++)
            {
                
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }*/

            /*for (int i = int.Parse(Console.ReadLine()) - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
            }*/
            for (int i = 0, j = 5; i < 5; i++, j--)
            {
                Console.WriteLine("i:" + i);
                Console.WriteLine("j:" + j);
            }

            Console.ReadLine(); 
#endif
#if BREAK_CONTINUE
            //break - прерывает работу цикла
            /* for (int i = 0; i < 100; i++)
             {
                 string msg = Console.ReadLine();
                 if (msg == "exit") break;
                 Console.WriteLine(i);
             }*/

            //continue - прерывает выполнение итерации цикла, но не выходит за тело цикла полностью
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                    continue;
                Console.WriteLine(i);
            }

            Console.ReadLine(); 
#endif
#if NESTED_LOOPS
            /*for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("Цикл 1 итерация №:" + i);
                    for (int j = 1; j <= 5; j++)
                    {
                        Console.WriteLine("\tЦикл 2 итерация №:" + j);
                        for (int k = 1; k <= 2; k++)
                        {
                            Console.WriteLine("\t\tЦикл 3 итерация №:" + k);
                        }
                    }
                }*/
            Console.Write("Введите высоту прямоугольника:");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника:");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            } 
#endif
#if TERNARY_OPERATOR
            /*int a = 0;
               a++;        //Унарный оператор
               int b = 1;
               int c = a + b; //Бинарный оператор

               bool accessAllowed;

               string storagePassword = "qwerty";
               string enterPassword = Console.ReadLine();
               accessAllowed = enterPassword == storagePassword ? true : false;
               Console.WriteLine(accessAllowed);*/

            int inputData = int.Parse(Console.ReadLine());

            int outputData = (inputData < 0) ? 1 : inputData;
            Console.WriteLine(outputData); 
#endif
#if ARRAY
            //Объявление массива
            /*int[] myArray = new int[5];

            myArray[1] = 5;
            myArray[4] = 10;

            Console.WriteLine(myArray[1]);*/

            //Способы инициализация массива
            //1)int[] myArray = new int[5] {1,2,3,4,5+1};
            //2)int[] myArray = new int[] {1,2,3,4,5+1,7};
            //3)int[] myArray = new [] {1,2,3,4};
            //4)int[] myArray = {1,2,3,4,5};

            //int[] myArray = Enumerable.Repeat(5, 10).ToArray(); //Метод Repeat повторяет элемент 5 десять раз и создаёт массив
            // int[] myArray = Enumerable.Range(4, 5).ToArray();  //Метод Range позволяет заполнить массив начиная с цифры 4. То есть 4,5,6,7,8

            //Массивы & циклы
            int[] myArray = { 10, 3, 2, 55 };

            /*for(int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " "); 
            }*/

            //Как работают с массивами в продакшене
            //Console.WriteLine(myArray.Max());     //Максимальный элемент массива
            //Console.WriteLine(myArray.Where(i=>i%2==0).Sum());  //Считает сумму всех чётных чисел 
            //Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());

            //int[] result = myArray.Distinct().ToArray();  //Выбирает только уникальные элементы в массиве
            //int[] result = myArray.OrderBy(i => i).ToArray();   //Сортирует элементы старого массива по возрастанию
            //int[] result = myArray.OrderByDescending(i => i).ToArray(); //Сортирует элементы старого массива по убыванию

            //Array.Sort(myArray);
            //Array.Reverse(myArray);
            //int[] result = myArray.Where(i => i < 50).ToArray();    //Позволяет найти элементы, которые меньше 50
            //int result = myArray.Where(i => i < 50).First();    //Позволяет найти первый элемент, который меньше 50
            int result = myArray.Where(i => i < 0).FirstOrDefault();    //Если в массиве нет элементов меньше 0, вернётся 0(default)

            Console.ReadLine(); 
#endif
#if INDEX_AND_RANGE
            //Индексы и диапазоны в C#8
            //Нужны для удобной работы с массивами, строками и списком
            //Проект Lesson_Core
#endif
#if MULTIPLE_ARRAY
            //Двумерный прямоугольный массив
            //Создание и вывод на экран
            //тип_данных [,] имя_массива;
            /*int[,] myArray =  
            {
                {2,45,12,51,65},
                {6,78,9,0,3},
                {1,100,92,45,33},
                {1,2,3,4,5},
                {15,42,33,47,59}
            };*/
            /*foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }*/
            //Console.WriteLine( myArray.GetLength(1) );  //0 - кол-во элементов по вертикали, 1 - по горизонтали

            //int height = myArray.GetLength(0);
            //int width = myArray.GetLength(1);
            /*for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i,j] + "\t");
                }
                Console.WriteLine();
            }*/
            //Console.WriteLine(myArray[1,3]);

            //Заполнение массива случайными числами
            /*int[,] myArray = new int[10, 6];

            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(100);   //Метод Next генерирует случайные числа
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i,j] + "\t");
                }
                Console.WriteLine();
            }*/

            //Заполнение массива с клавиатуры
            /*string[,] myArray = new string[2, 3];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Y: " + i + " X: " + j);
                    myArray[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }*/

            //Двумерный зубчатый массив
            /*int[][] myArray = new int[4][];     //Объявление двумерного зубчатого массива. [][] - массив массивов
            myArray[0] = new int[5];
            myArray[1] = new int[2];
            myArray[2] = new int[10];
            int[,] myArray2 = new int[3, 5];   //Объявление двумерного прямоугольного массива

            int myArrayRank = myArray.Rank;     //Rank - показывает кол-во измерений массива
            int myArray2Rank = myArray2.Rank;

            int myArrayLength = myArray.Length; //Length - показывает кол-во элементов массива
            int myArray2Length = myArray2.Length;

            myArray[0][3] = 55;
            int[] arr = myArray[0];
            Console.WriteLine(arr[3]);*/

            //Заполнение двумерного зубчатого массива случайными числами и вывод на экран
            /*int[][] myArray = new int[4][];
            myArray[0] = new int[5];
            myArray[1] = new int[7];
            myArray[2] = new int[9];
            myArray[3] = new int[2];
            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }
            
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }*/

            //Трёхмерные и более мерные массивы
            /*int[,,] myArray =   //Объявление трёхмерного прямоугольного массива
            {                   //Инициализация трёхмерного массива
                {
                    {2,3,5},
                    {69,7,4}
                },
                {
                    {4,31,24},
                    {64,7,33}
                },
                {
                    {4,21,9},
                    {8,12,1}
                }
            };*/
            //myArray[0, 2, 3] = 55;

            /*int[,,] myArray = new int[4, 3, 5];
            Random random = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = random.Next(100);
                    }
                }
            }
            
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Страница №: " + (i+1));
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i,j,k] + " "); ;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }*/

            //Объявление трёхмерного зубчатого массива
            Random random = new Random();
            int[][][] myArray = new int[random.Next(3,6)][][];
            
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new int[random.Next(2, 6)][];
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = new int[random.Next(2, 6)];
                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        myArray[i][j][k] = random.Next(100);
                    }
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        Console.Write(myArray[i][j][k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
#endif
#if FUNCTIONS_METHODS
            //модификаторы тип_возвращаемого_значения название_метода(параметры)
            /*{
                тело_метода
            }*/
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine()); Console.WriteLine();
            
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine()); Console.WriteLine();
           
            //Console.WriteLine(Addition(a, b));
            int c = Addition(a,b);
            PrintResult(c);
            PrintLine();

#endif
#if FUNCTION_OVERLOADING
            //Перегрузка функций или методов нужна для того, чтобы функция или метод могли работать 
            //с разными типами данных
            int result = Addition(2, 3);
            Console.WriteLine(result);

            int result1 = Addition(2, 3, 4);
            Console.WriteLine(result1);

            double result2 = Addition(2.4, 5.8);
            Console.WriteLine(result2);
#endif
#if VALUETYPES_REFERENCETYPES
            //Stack - небольшой объём оперативной памяти, который выделяется для каждого потока.
            //Дефолтное значение 1 Мб. Используется для хранения переменных, которые мы создаём, используется для выполнения операций
            //над этими переменными, а также используется для вызова методов.

            //Heap - что-то вроде "склада" в оперативной памяти, который мы можем использовать по мере надобности.
            //Объём кучи зависит от платформы на которой запускается наша программа и от ОС, например, если у нас 32х
            //разрядный процесс, то мы можем выделить для кучи около 1.5 Гб памяти, а если 64х разрядный процесс, то до 8 Тб памяти.

            //Stack и Heap - это оперативная память, грубо говоря stack, это мало, но быстро, а heap, это много, но медленно.

            //Value type(значимый тип) размещается в стеке, Reference type(ссылочный тип) размещается в куче.
            //Все типы данных, которые являются структурами(struct) или перечислениями(enum) - это значимые типы, соответственно они размещаются в стеке,
            //если же это не структура и не enum, а класс(class), то этот тип данных размещается в управляемой куче.

            //int a = 5; <- int  - это структура, поэтому данные размещены в стеке
            //System.Int32 b = 5;

            //Random random = new Random(); <- Random - это класс, соответственно данные размещены в куче

            //int[] arr = new int[10]; //<- int[] - это структура, однако т.к. это наследник класса Array, данные размещены в куче  
#endif
#if NULL_NULLUNIT
            //null - ссылка на 0, аналог nullptr в С++
            /*int[] a;
            a = new int[10];
            a = null;*/   //<-Garbidge collector весь в работе

            //Оператор null-объединения ??
            //string str = null;

            /*if(str == null)
                Console.WriteLine("нет данных");
            else
                Console.WriteLine(str);*/
            //Console.WriteLine(str ?? "Нет данных"); //Если str == null, выводится дефолтное значение - "Нет данных",
                                                      //если str != null, выводится str
            /*string result = str ?? string.Empty;    //В результат либо str, либо string.Empty, если null
            Console.WriteLine("Количество символов с строке " + result.Length);*/
            //Далее пример в Null_unitWF

            //Оператор присваивания объединения со значением Null ??=
            /*string str = null;
            //Если str == null переменной str присваивается строка "default string"
            str ??= "default string";
            Console.WriteLine("количество символов в строке: " + str.Length);*/

            /*int[] array = null;
            array ??= new int[0];
            Console.WriteLine("количество элементов в массиве " + array.Length);*/

            //Оператор условного null ?.
            //Можно проверять массив на null таким образом, однако зачем, когда есть ?.
            /*int[] array = null;
            string result = array == null ? "Ошибка" : (array.Sum()).ToString();
            Console.WriteLine("Сумма элементов массива " + result);*/

            //Оператор условного нуля проверяет равен ли массив null, если да, то array.Sum() не
            //выполняется, если array != null, то выполняется array.Sum()
            //int[] array = null;
            //Можно ?. комбинировать с ??, если мы хотим видеть дефолтное значение при array = null
            //Console.WriteLine("Сумма элементов массива " + (array?.Sum() ?? 0));
            //Далее пример в Null_unitWF
#endif
#if KEYWORDS_REF_OUT_IN_PARAMS
            //Ключевое слово ref(Позволяет изменять переданную переменную)
            //При передаче параметров с ключевым словом ref, мы передаём его по ссылке.
            //Это означает, что мы не копируем параметры в локальную переменную, а работаем с одними и теми же данными
            //Передача аргументов по ссылке
            /*int a = 2;
            Foo(ref a);
            Console.WriteLine(a);*/

            /*int[] array = { 1, 4, 14, 2 };
            Bar(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();*/

            int[] arr = { 2, 6, 1 };
            //ref int b - ссылочная локальная переменная
            //ref int b = ref arr[0];
            ref int b = ref Func(arr);
            //как только мы в b поместили -5, то в нулевом элементе массива тоже будет -5,
            //т.к. это ссылочная локальная переменная
            b = -5;

            //Ключевое слово out(Обязывает изменять переданную переменную)
            //При передаче параметров с ключевым словом out, мы передаём его по ссылке 
            //Разниуа между ключевым словом ref и out состоит в том, что при передаче параметров при
            //помощи ref, мы можем не изменять переменную, которую предаём, однако, при передаче с помощью
            //out, мы той переменной, которую передаём обязаны присвоить значение
            int a1 = 10;  
            Foo1(ref a1);
            Bar1(out int c);
            string str = Console.ReadLine();
            int.TryParse(str, out int result);  //Задача метода TryParse в преобразовании строки в тип int
            Console.WriteLine(result);

            //Ключевое слово in(Не позволяет изменять переданную переменную)
            //Появилось в версии 7.2
            //При передаче параметров с ключевым словом in, мы передаём его по ссылке 
            //При передаче параметра с ключевым словом in, переменная которую мы в метод передали
            //не имеет возможности изменятся, становится по сути read only
            int a2 = 5;
            Foo2(a2);   //Не обязательно писать in при передаче параметров

            //Ключевое слово params
            //При разработке наших методов, не редко случается ситуация, когда нужно передать
            //в метод с одинаковой логикой разное количество параметров, для этого существует
            //пергрузка методов, однако, это выливается в большое кол-во строк кода. Именно для
            //этих целей существует ключевое слово params, оно позволяет передать в метод сколько
            //угодно параметров

            int result1 = Sum(4,5,6,8); //<- Можем передать сколько угодно параметров
            Console.WriteLine($"Сумма элементов: {result1}");

            //Данные с ключевым словом params должны передоватся в метод самыми последними, это
            //и логично, ведь иначе компилятор не поймёт где заканчиваются принимаемые параметры,
            //params передаётся в метод почти как параметры по умолчанию в C++, то есть он всегда
            //один в методе и всегда самый последний
            //int result2 = Sum("test", 45, 65, 32); //<- Так правильно
            //int result2 = Sum(45, 65, 32,"test"); //<- Так НЕ правильно

#endif
#if NAMED_DEFAULT_PARAMETERS
            //Параметры по умолчанию
            //Всё так же, как и в С++, параметры по умолчанию передаются всегда последними, их может
            //быть сколько угодно, при вызове метода их передавать необязательно

            //Именованные параметры, аргументы
            //При использовании именованных параметров, нам не обязательно передавать их в том порядке
            //в каком они принимаются в метод, вместо этого мы можем передать их так:
            //тип_данных имя_переменной = имя_метода(параметр_1: значение, параметр_2: значение)

            int result = Sum(enableLogging:true, a:500, b:1000); //Можем передать хоть так
            //Console.WriteLine(result);

#endif
#if RECURSION
            Foo(0);
#endif
#if TYPE_CONVERSION
            //Преобразование типов - процесс конвертации или привидения объекта одного типа данных в другой
            //Преобразования бывают явные, не явные, сужающие и расширяющие
            //Если с явными и не явными всё понятно, все правила как и в С++, то сужающие преобразования
            //это когда мы объект больший "упаковываем" в объект меньший по размеру, например из double проебразовываем
            //во float, или из int в byte, !!!есть риск потери даных!!!, с расширяющими преобразованиями всё наоборот, это когда мы
            //объект меньший по размеру и диапазону значений преобразуем в объект больший по размеру, например из int в long

#endif
#if ARIFMETICAL_OVERLOAD_CHECKED_UNCHECKED
            //Баг с ядерным Ганди в игре Civilization основан на арифметическом переполнении, при котором мирный полководец Ганди
            //внезапно атаковал других игроков ядерными бомбами 
            byte agression = 1;
            byte democracyModifier = 2;
            /*checked
            {
                //Ключевое слово checked позволяет отслеживать переполнение не целого проекта, а отдельного выражения
                agression = (byte)(agression - democracyModifier);
            }*/
            //Если же проверка включена во всём проекте, ключевое слово unchecked позволяет нам пропустить проверку
            try
            {
                agression = checked((byte)(agression - democracyModifier));  //сужающее преобразование данных
                Console.WriteLine(agression);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка переполнения!");
            }
            

            //Переполнение в С# бывает через нижнюю границу:
            int bottom = int.MinValue;
            bottom = bottom - 1;
            Console.WriteLine(bottom);  //bottom == int.MaxValue

            //И через верхнюю границу:
            int top = int.MaxValue;
            top = top + 1;
            Console.WriteLine(top);     //bottom == int.MinValue

            //Чтобы контролировать переполнение на уровне проекта переходим Solution Explorer -> FirstApp(ПКМ)/Properties -> Build
            //-> Advanced -> Check for arifmetical overflow, тогда в 873 строке будет исключение, эта проверка замедляет выполнение программ

#endif
#if NULLABLE_TYPES
            //Null-совместимые типы (Nullable)
            /*string str = null;  
            int a = null;   
            DateTime dateTime = null;
            DateTime? dateTime = null;*/

            int? i = null;
            //int? i = 2;
                                                        //null         //Value = 2
            Console.WriteLine(i==null);                 //true         //false
            Console.WriteLine(i.HasValue);              //false        //true
            Console.WriteLine(i.GetValueOrDefault());   //0            //2
            Console.WriteLine(i.GetValueOrDefault(3));  //3            //2
            Console.WriteLine(i ?? 55);                 //55           //2
            //Console.WriteLine(i.Value);               //Invalid      //2
            //                                          Operation
            //                                          Exception
            Console.WriteLine(i);                       //Ошибки нет   //2
#endif
#if KEYWORD_VAR
            //Ключевое слово var
            //неявно типизированные локальные переменные

            //var - это НЕ тип данных, это ключевое слово, которое указывает компилятору на тот тип данных,
            //который мы хотим присвить в переменную

            var t = 5; //var = int
            var str = "Hello World!"; //var = string
            var arr = new float[10]; //var = float[]
            Console.WriteLine
                ($"{t.GetType()}\n{str.GetType()}\n{arr.GetType()}");   //Single == float
            var s = "test";
            s = null;
            var ss = (string)null;  //Абсолютно бесполезная строка, но так можно делать

            //Dictionary<int, string> dictionary = new Dictionary<int, string>();   //Либо так
            var dictionary = new Dictionary<int, string>();     //Либо так, так правильнее

            //var хорошо использовать с анонимными типами данных
            var ano = new { Name = "Мартин", Age = 25 };
            Console.WriteLine(ano.GetType());

            //var и LINQ
            int[] numbers = { 1, 5, 344, 40, 1, 24, 567, 32, 975, 97, 35 };

            //Дословно Из числа в массиве numbers где число больше 50 выбрать число
            var result = from i in numbers where i > 50 select i;
            Console.WriteLine(result.GetType());
            //Дословно Из числа в массиве numbers где число больше 50 отсортировать и выбрать число
            result = from i in numbers where i > 50 orderby i select i;

            foreach (var item in result)
            {
                Console.WriteLine($"{item}\t");
            }
            Console.WriteLine();
            Console.WriteLine(result.GetType());

            //Когда нельзя использовать var:
            //1) В сигнатуре метода, var не может быть параметром метода (static void Bar(var a))
            
            //2) var не может быть возвращаемым параметром, есть исключение с обобщениями, но пока не о них
            //(static var Foo(int a, int b))
            
            //3) var не может быть переменным членом(полем) класса
            /*class MyClass
            {
                public var a = 0; 
            }*/

            //Ключевое слово var можно использовать только в локальном контексте программы
            //var t = 90; //Поэтому и называется неявно типизированная ЛОКАЛЬНАЯ переменная
            
#endif
#if ENUM
            //enum(перечисления)
            //enum - это некий диапазон значений, список констант, который ограничивается конкретной логикой
            /*while(true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                int keyCode = (int)key;
                Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");

                switch (key)
                {
                    case ConsoleKey.Enter: Console.WriteLine("Вы нажали enter"); break;
                    case ConsoleKey.Backspace: Console.WriteLine("Вы нажали back space"); break;
                    case ConsoleKey.Delete: Console.WriteLine("Вы нажали delete"); break;
                }
            }*/

            /*DayOfWeek dayOfWeek = DayOfWeek.Sunday; //Экземпляр перечисления
            //typeof возвращает тип данных
            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));
            Console.WriteLine(dayOfWeek);
            Console.WriteLine((int)dayOfWeek);  //Приводим dayOfWeek к int, получаем номер Четверга
            Console.WriteLine((DayOfWeek)3); //Приводим int к DayOfWeek, получаем значение под номером 3
            Console.WriteLine(nextDay(dayOfWeek));*/

            /*DayOfWeek dayOfWeek;
            byte value = 5;
            //dayOfWeek = (DayOfWeek)value;
            //Метод IsDefined проверяет, есть ли в нашем enum, значение которое находится в перменной value
            if (Enum.IsDefined(typeof(DayOfWeek), value))
            {
                dayOfWeek = (DayOfWeek)value;   //Приводим int k DayOfWeek
            }
            else
            {
                throw new Exception("Invalid DayOfWeek value");
            }
            Console.WriteLine(dayOfWeek);*/

            //Метод GetValues позволяет получить инфо о всех доступных значениях
            /*var values = Enum.GetValues(typeof(Color));
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }*/
            Console.WriteLine("Напишите какой цвет хотите вывести");
            string str = Console.ReadLine();
            //Если ignoreCase == true, это значит, что он будет игнорировать большие и маленькие буквы
            Color color = (Color)Enum.Parse(typeof(Color), str, ignoreCase: true);
            Console.WriteLine(color);


            switch (color)
            {
                case Color.White:
                    break;
                case Color.Red:
                    break;
                case Color.Green:
                    break;
                case Color.Blue:
                    break;
                case Color.Orange:
                    break;
                default:
                    break;
            }
#endif
#if OOP_CLASS_OBJECT
            //ООП   Класс   Объект
            /*Point point = new Point();  //Создание и инициализация объекта
            //point = null; //Если point == null, мы не имеем связи с переменными полями класса
            point.X = 10;
            point.Y = 8;
            point.color = Color.Blue;

            Console.WriteLine("X:{0}\tY:{1}\tColor:{2}",point.X, point.Y, point.color);

            Point point1 = new Point();
            point1.X = 4;
            point1.Y = 2;

            Console.WriteLine("X`:{0}\tY`:{1}", point1.X, point1.Y);*/

            var firstStudent = Program.GetStudent();
            Program.Print(firstStudent);
#endif
#if OOP_METHODS
            //ООП
            //Методы объекта класса
            var firststudent = Program.GetStudent();
            //firststudent.Print();
            string fullname = firststudent.GetFullName();

            /*Console.WriteLine();
            Console.WriteLine();

            var secondstudent = new Student();
            secondstudent.firstName = "Martin";
            secondstudent.Print();*/
#endif
#if PUBLIC_PRIVATE_INCAPSULATION
            //модификаторы доступа public & private
            //public - даёт доступ к полям класса на уровне объекта
            //private - НЕ даёт доступ к полям класса на уровне объекта
            /*PPoint point = new PPoint();
            point.PrintPoint();*/

            //Получаем информацию о модификаторах доступа
            /*var typeinfo = typeof(PPoint).
                GetFields(BindingFlags.Instance | 
                BindingFlags.NonPublic | 
                BindingFlags.Public);

            foreach(var item in typeinfo)
            {
                Console.WriteLine($"{item.Name}\t" +
                    $"isPrivate:{item.IsPrivate}\t" +
                    $"isPublic:{item.IsPublic}");
            }*/

            //Инкапсуляция
            //Суть инкапсуляции состоит в том, что мы скрываем состояние объекта, защищаем его от внешнего
            //мира и даём возможность изменить это состояние только с помощью методов этого же объекта
            Gun gun = new Gun();
            gun.Shoot();
#endif
#if CONSTRUCTOR_DEFAULT_CONSTRUCTOR
            //Конструктор
            //Конструктор по-умолчанию
            //Конструктор - это метод, который вызывается для создания объекта
            /*Gun gun = new Gun(isLoaded:false);
            for (int i = 0; i < 3; i++)
            {
                gun.Shoot();    //O(1);
            }*/

            //Перегрузка конструкторов
            /*PPoint point = new PPoint(3, 5);    //Overloaded constructor
            PPoint pPoint = new PPoint();   //Default constructor
            point.PrintPoint();
            pPoint.PrintPoint();*/

            Student student = new Student("Шапошкин", new DateTime(2000, 10, 5));
            Student student1 = new Student(student);

            student.SetLastname("#####3#");

            student.Print();
            Console.WriteLine();
            student1.Print();
#endif
#if KEYWORD_THIS
            //this
            //Благодаря ключевому слову this, мы можем получить доступ к текущим полям класса
            Student student = new Student("Шапошников","Пётр", "Иваныч", new DateTime(2000,10,5));
            //нельзя писать ключевое слово this в static классах, методах, потому что, когда мы используем static методы
            //у нас нет необходимости создавать экземпляры static класса, this даёт нам доступ к текущему экземпляру класса,
            //а как можно получить доступ к тому, чего нет?
            student.Print();
#endif
#if PROPERTIES
            //Свойства(Properties)
            //Автоматические свойства
            
            Point point = new Point();
            point.SetX(3);
            int x = point.GetX();
            Console.WriteLine(x);

            //point.Y = 10;
            int y = point.Y;

            point.Z = 10;
            int z = point.Z;
            Console.WriteLine(z);

#endif
#if STATIC_CLASS
            //Ключевое слово static
            //Статические поля класса

            //Если переменное поле класса static, то нам нет необходимости создавать экземпляр того класса
            //Если поле не статическое, то у каждого экземпляра класса будет свой собственный экземпляр этого поля
            //и там можно хранить разные данные
            //Если же поле статическое, то данные хранятся в отдельной области памяти

            /*MyClass class1 = new MyClass();
            class1.a = 44;  //Не статический экземпляр
            MyClass class2 = new MyClass();
            class2.a = 22;
            MyClass.b = 23;*/   //Статический экземпляр

            /*MyClass myClass1 = new MyClass();
            myClass1.SetB(10);  //b=10

            MyClass myClass2 = new MyClass();
            myClass2.PrintB();*/ //10

            //Статические методы класса
            //Статические свойства класса

            //Если мы применяем ключевое слово static к методу, мы можем его использовать не создавая экземпляр
            //класса
            //В статических методах невозможно использовать не статические члены класса
            //Но в не статических методах могут быть вызваны статические методы на уровне экземпляра класса

            /*MyClass myClass = new MyClass();
            //myClass.Foo();    //Ошибка
            myClass.Bar();
            //MyClass.Foo();

            MyClass.A = 3;
            MyClass.C = 5;*/

            /*CountClass countClass1 = new CountClass();
            CountClass countClass2 = new CountClass();
            CountClass countClass3 = new CountClass();
            CountClass countClass4 = new CountClass();
            CountClass countClass5 = new CountClass();

            Console.WriteLine(countClass1.GetObjectsCounter()); 
            Console.WriteLine(CountClass.Counter);
            Console.WriteLine(CountClass.GetCounter());
            Console.WriteLine(countClass1.ObjectCount);*/

            //Статический конструктор

            //Конструктор класса - метод класса, который используется, чтобы создать класс, сконструировать его
            //Статический конструктор работает так же как и обычный конструктор, но только для всего, что
            //имеет ключевое слово static(полей, методов, свойств)
            //Статический конструктор всегда выполняется один раз при первом создании объекта, точнее до него

            /*Class class1 = new Class();
            new Class();
            new Class();
            new Class();

            Class.Foo();
            new Class();
            new Class();
            new Class();*/

            /*DbRepository dbRepository = new DbRepository();

            dbRepository.GetData();*/

            //Статический класс

            //Как только мы добавим модификатор static в наш класс, мы не можем создать объект такого класса
            //либо же экземпляр, что одно и тоже
            //В статических классах, не возможно использовать не статические поля, методы, переменные и т.д,
            //потому что для не статических членов класса, для того, чтобы их использовать нам надо создать экземпляр
            //класса и у каждого экземпляра класса вот эти вот не статические компоненты свои собственные, а так как 
            //класс у нас статический это означает, что мы впринципе никогда не сможем создать экземпляр этого класса,
            //соответственно использовать такие не статические перемнные поля, свойства, методы вообще не имеет смысла,
            //потому что мы всё равно не сможем ими воспользоваться

            //Статические классы не умеют в наследовании и не умеют в интерфейсах

            Myclass1.Foo3();
            

#endif
#if EXTENSION_METHODS
            //Extension методы(методы расширения)

            //Суть методов расширения заключается в том, чтобы добавить новый функционал в уже существующие классы или 
            //структуры и не модифицируя их

            //1. Extension методы должны находится в статических классах и сами должны быть статическими
            //2. В крупных проектах хорошо бы изолировать методы расширения, для того, чтобы их могли использовать
            //только мы, для этого мы должны поменять пространство имён в классе в котором пишем методы расширения 

            DateTime currentDateTime = DateTime.Now;
            currentDateTime.Print();
            Console.WriteLine(currentDateTime.IsDayOfWeek(System.DayOfWeek.Sunday));

            Abiturient abiturient = new Abiturient() { FirstName = "Мартин", lastName = "Дугин" };
            string fullName = abiturient.GetFullName();
            Console.WriteLine(fullName);

            
#endif
#if KEYWORD_PARTIAL
            //Ключевое слово partial
            //Частичные типы
            //partial классы
            //partial методы

            //Когда мы используем ключевое слово partial вместе с классом, оно позволяет код этого класса
            //разнести по разным файлам, таким образом наш класс превращается в частичный
            //Чтобы реализовать partial класс достаточно поставить ключевое слово partial, создать файл с новым
            //классом в который мы будем делить предыдущий класс и в новый класс добавить то, что нам нужно из делимого класса.
            //У обоих классов сигнатура должна быть например: public partial class Human

            // !!!!PARTIAL МЕТОДЫ ДОСТУПНЫ ТОЛЬКО В С# 9.0 И ВЫШЕ!!!!
            //Когда мы используем ключевое слово partial вместе с методом, оно позволяет код этого метода
            //разнести на части, так что разные части этого метода будут в разных частях partial класса
            //Чтобы реализовать partial методы нам нужно в делимом классе оставить только сигнатуру метода со словом partial,
            //например: public partial string GetFullName();, а в классе делителе оставить полную реализацию метода вместе с сигнатурой и 
            //ключевым словом partial, например:
            /*public partial string GetFullName()
            {
                //Возврат полного имени человека
            }*/


            Person person = new Person("Петр", "Иванович");
            person.PrintFullName();
#endif
#if CONST_READONLY
            //const и readonly

            //Модификатор const позволяет сделать так, чтобы у нас никогда не было возможности изменить
            //данные в переменных полях после того, как мы их туда поместили
            //При создании const переменных полей класса, их необходимо инициализировать, иначе проект не скомпилируется 
            //Все поля у которых есть модификатор const - неявно статические, это всё равно, что static const и явно присвоить
            //модификатор static неполучится

            //Модификатор readonly позволяет создать переменную и не инициализировать её при создании, но инициализировать
            //её мы можем, и при этом readonly не является неявно static и мы можем присвоить модификатор static
            //Мы нигде не можем присвоить значение переменной readonly, кроме как при создании и в конструкторе и после
            //присвоения туда данных изменить их мы уже не сможем
            //Все static readonly поля нужно инициализировать в static конструкторе

            //Consts consts = new Consts(4);
            Console.WriteLine( Consts.PI );
            //Consts.b = 3;   //Error
            Console.WriteLine(Consts.b);
            
#endif
#if SYNTACS_OBJECT_INITIALIZE
            //Синтаксис инициализации объектов
           
            //В первом случае у нас сначала создаётся объект, а потом присваиваются данные в поля
            Cat cat = new Cat();
            cat.Age = 3;
            cat.Name = "Боня";

            //Во втором случае у нас полная инициализация объекта со всеми его полями
            Cat cat1 = new Cat
            {
                Age = 3,
                Name = "Боня"
            };

            Cat cat2 = new Cat("Барсик");
            cat2.Age = 3;

            Cat cat3 = new Cat("Барсик")
            {
                Age = 3
            };

            //Результат показыает, что примеры кода во вторых случаях более читабельны и лучше для восприятия
#endif
#if INHARITANCE
            //Наследование в ООП

            //Множественное наследование в С# как таковое запрещено

            /*Student student = new Student { FirstName = "Санёк", LastName = "Иванов" };
            student.FullName();
            student.PrintWork();

            Employee employee = new Employee { FirstName = "Роман", LastName = "Сащеко" };
            employee.FullName();
            employee.PrintWork();*/

            //Наследование, конструкторы класса и ключевое слово base

            //Ключевое слово base позволяет нам в конструкторе наследника, реализовать все функции 
            //конструктора родителя(базового класса), а также base, как и this в некоторых случаях
            //помогает внести ясность в логику программы, если this - это указатель на объект текущего класса,
            //то base - указатель на объект базового класса

            /*Point3D point3D = new Point3D(5,4,3);
            point3D.Print3D();*/

            //Привидение типов и наследование
            //Использование операторов is и as

            /*object obj = new Point2D(3,5);
            //object obj = " ";
            //В данном случае мы явно говорим компилятору, что obj, это на самом деле Point2D
            //Point2D point = (Point2D)obj;
            //Foo(obj);
            Bar(obj);*/

            //Модификатор доступа protected при наследовании

            //Модификатор protected никогда не доступен на уровне объекта класса, но доступен в классе
            //наследнике

            /*A a = new A();
            Console.WriteLine(a.publicField);      //Поле доступно
            //Console.WriteLine(a.privateField);   //Поле не доступно
            //Console.WriteLine(a.protectedField); //Поле не доступно

            B b = new B();
            Console.WriteLine(a.publicField);      //Поле доступно
            //Console.WriteLine(a.privateField);   //Поле не доступно
            //Console.WriteLine(a.protectedField); //Поле не доступно

            b.foo();
            b.bar();*/
#endif
#if POLYMORPHISM
            //Полиморфизм
            //Виртуальные методы
            //модификатор virual
            //модификатор override

            //Полиморфизм - это инструмент в ООП который может использоваться при наследовании
            //Виртуальным называется метод, который может быть переопределён в дочернем классе, для этого
            //у метода, который в базовом классе должно быть ключевое слово virtual, а у метода, которы в 
            //дочерем классе должно быть ключевое слово override

            //Car car = new SportCar();
            Driver driver = new Driver();
            driver.Drive(new SportCar());
#endif
#if ABSTRACT_CLASS
            //Полиморфизм
            //Абстрактный класс
            //Абстрактный метод
            //Абстрактные свойства

            //Абстрактный класс не имеет экземпляров класса
            //Абстрактный класс нужен для того, чтобы описать такие вещи как, транспорт, животные, оружие и т.д.
            //Абстрактные методы должны находится только в абстрактных классах
            //Абстрактные методы не имеют реализацию, реализацию(переопределение) абстрактного метода выполняет дочерний класс
            //унаследованный от абстрактного класса

            Player player = new Player();
            /*Pistol pistol = new Pistol();
            MachineGun machineGun = new MachineGun();
            GrenadeLauncher grenadeLauncher = new GrenadeLauncher();
            string[] weapons = { "Пистолет", "Пулемёт", "Гранатомёт" };
            Weapon[] inventory = { new Pistol(), new MachineGun(), new GrenadeLauncher() };

            Console.WriteLine("Выберите из чего хотите выстрелить:");
            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {weapons[i]} Урон: {inventory[i].Damage}");
            }
            char choose = char.Parse(Console.ReadLine());
            switch (choose)
            {
                case '1': player.Fire(pistol); break;
                case '2': player.Fire(machineGun); break;
                case '3': player.Fire(grenadeLauncher); break;
            }*/

            Weapon[] inventory = { new Pistol(), new MachineGun(), new GrenadeLauncher() };
            foreach (var gun in inventory)
            {
                player.CheckInfo(gun);
                player.Fire(gun);
                Console.WriteLine();
            }
            player.CheckInfo(new Box());
#endif
#if INTERFACES
            //Интерфейсы и полиморфизм
            //С помощью интрефейса мы определяем поведение, которое в последствии будет реализовано 
            //в каком-то конкретном классе
            //Главным отличием интерфейса от абстрактного класса, в том что интерфейс позволяет 
            //множественное наследование, они могут наследоваться между собой, причём один интерфейс может
            //наследовать несколько разных, так и один определённый класс может наследовать несколько интерфейсов
            //!!!В интерфейсе, в отличии от абстрактного класса не может быть конструктора и переменных
            //членов, это связанно с тем, что интерфейс должен определять поведение и контракт, но не должны
            //содержать реализации!!!

            /*IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new ApiDataProvider());*/

            //Наследование интерфейсов
            //Множественное наследование интерфейсов

            /*Player1 player1 = new Player1();
            IWeapon1[] guns = { new Gun1(), new LaserGun1(), new Knife() };

            foreach (var gun in guns)
            {
                player1.Fire(gun);
                Console.WriteLine();
            }
            player1.Throw(new Knife());*/

            //Явная реализация интерфейсов
            //В C# класс может реализовать 2 интерфейса у которых одинаковые методы, если нам нужна 
            //разная реализация этих методов, нам нужно реализовать эти интерфейсы явно
            YouClass youClass = new YouClass();
            Foo(youClass);
            Bar(youClass);

            YouOtherClass youOtherClass = new YouOtherClass();
            /*Foo(youOtherClass);
            Bar(youOtherClass);*/

            /*IFirstInterface firstInterface = youOtherClass;
            firstInterface.Action();*/

            /*((IFirstInterface)youOtherClass).Action();
            ((ISecondInterface)youOtherClass).Action();*/

            //object obj = new object();
            //Если объект youOtherClass реализует интерфейс IFirstInterface
            if(youOtherClass is IFirstInterface firstInterface)
            {
                //Выполняется метод Action()
                firstInterface.Action();
            }
#endif
        }
        static void Foo(object obj)
        {
            //С помощью оператора as преобразовываем obj в тип данных Point2D
            //Преимущество в преобразовании с помощью оператора as состоит в том, что если в принимаемые
            //параметры функции попадёт объект типа Point2D, то логика успешно пойдёт выполнятся дальше, а
            //если в принимаемые параметры попадёт объект другого типа, то в переменную запишется null и 
            //исключения не будет
            Point2D point = obj as Point2D;
            //В данной ситуации если в принимаемые параметры функции попадёт объект типа Point2D,
            //то логика успешно пойдёт выполнятся дальше, а если в принимаемые параметры попадёт
            //объект другого типа, то выпадет исключение
            //Point2D point = (Point2D)obj;
            if (point != null)
            {
                point.Print2D();
            }
            else
                Console.WriteLine("point = null");
        }
        static void Bar(object obj)
        {
            //Оператор is просто позволяет проверить тип данных в переменной obj
            /*if(obj is Point2D)
            {
                //При таком условии "небезопасное" приведение типов не бросит исключение, потому что
                //мы точно знаем, что в obj тип данных Point2D
                Point2D point = (Point2D)obj;
                point.Print2D();
            }*/
            //В версии якыка 7.0 можно сразу после проверки типа, если проверка была успешна, поместить данные
            //в отдельный объект
            if(obj is Point2D point)
            {
                point.Print2D();
            }
            else
                Console.WriteLine("obj != Point2D");
        }
        class Gun
        {
            //Поля состояния
            private bool _isLoaded;  //Заряжена
            //Поля поведения
            public Gun()
            {
                _isLoaded = true;
            }
            public Gun(bool isLoaded)
            {
                _isLoaded = isLoaded;
            }
            private void Reload()
            {
                Console.WriteLine("заряжаю...");
                _isLoaded = true;
                Console.WriteLine("заряжена!");
            }
            public void Shoot()
            {
                if (!_isLoaded)
                {
                    Console.WriteLine("Орудие не заряжено!");
                    Reload();
                }
                Console.WriteLine("Пиу пиу!\n");
                _isLoaded = false;
            }
        }
        class PPoint
        {
            int z = 3;  //По умолчанию private
            private int X;   //Координата Х
            private int Y;   //Координата Y
            public Color color; //Цвет точек

            public PPoint()
            {
                X = Y = 1;
            }
            public void SetX(int x)
            {
                X = x;
            }
            public int GetX()
            {
                return X;
            }
            public PPoint(int x, int y)
            {
                X = x;
                Y = y;
            }

            private void PrintX()
            {
                Console.WriteLine($"X: {X}");
            }
            private void PrintY()
            {
                Console.WriteLine($"Y: {Y}");
            }
            public void PrintPoint()
            {
                PrintX();
                PrintY();
            }
        }
        class Point
        {
            private int x;
            private int y;
            public int Z { get; set; }     //Автоматическое свойство
            public void SetX(int x) //setter
            {
                if (x < 1)
                {
                    this.x = 1;
                    return;
                }
                if (x > 5)
                {
                    this.x = 5;
                    return;
                }
                this.x = x;
            }
            public int GetX()   //getter
            {
                return x;
            }

            //Свойство:
            public int Y
            {
                //В данном контексте get и set - это аксессоры(accesors)
                //Если у какого-нибудь аксессора будет модификатор private, то мы не сможем получить
                //доступ к нему на уровне экзмепляра, в данном случае мы не можем присвоить данные полю y
                get
                {
                    return y;
                }
                private set
                {
                    if (value < 1)
                    {
                        y = 1;
                        return;
                    }
                    if (value > 5)
                    {
                        y = 5;
                        return;
                    }
                    y = value;
                }
            }


        }
        class MyClass
        {
            //private int a;
            private static int b;
            private static int a;

            public static int A
            {
                get { return a; }
                set { a = value; }
            }

            public static int C { get; set; }

            public static void Foo()
            {
                Console.WriteLine("Вызван метод Foo");
                b = 5;
                Console.WriteLine(b);
                //Bar();    //Ошибки
                //a = 5;
            }

            public void Bar()
            {
                Console.WriteLine("Вызван метод Bar");
                Foo();
                //Console.WriteLine(b);
            }

            /*public void SetB(int b)
            {
                //this.b = b;  //Ошибка
                MyClass.b = b;
            }

            public void PrintB()
            {
                Console.WriteLine(b);
            }*/
        }
        class CountClass
        {
            private static int counter;
            public CountClass()
            {
                counter++;
            }
            public static int Counter
            {
                get { return counter; }
                private set { counter = value; }    //Можем установить значение только внутри класса
            }
            public int ObjectCount
            {
                get { return counter; }
            }
            public static int GetCounter()
            {
                return counter;
            }
            public int GetObjectsCounter()
            {
                return counter;
            }
        }
        class Class
        {
            public Class()
            {
                Console.WriteLine("Конструктор");
            }
            //В любом классе можно использовать только 1 статический конструктор и он не может принимать параметры
            static Class()
            {
                Console.WriteLine("Статический конструктор");
            }

            public static void Foo()
            {
                Console.WriteLine("Foo");
            }
        }
        class DbRepository
        {
            private static string connectionString;

            static DbRepository()
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                connectionString = configurationManager.GetConnectionString();
            }
            public void GetData()
            {
                Console.WriteLine("Использую: " + connectionString);
            }
        }
        class ConfigurationManager
        {
            public string GetConnectionString()
            {
                return "local DB";
            }
        }
        static class Myclass1
        {
            public static void Foo3()
            {
                Console.WriteLine("Foo");
            }

        }
        class Consts
        {
            public const double PI = 3.14;  //Явно static
            public const string MY_ERROR = "some error";    //Явно static
            public readonly int a;  //Неявно static
            public static readonly int b;   //Неявно static
            static Consts()
            {
                b = 3;
            }
            public Consts(int a)
            {
                this.a = a;
            }
            public void Foo()
            {
                Console.WriteLine(PI);
                Console.WriteLine(MY_ERROR);
                Console.WriteLine(b);
            }
        }
        class Cat
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public Cat()
            {

            }
            public Cat(string name)
            {
                Name = name;
            }

        }
        class Human
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public void FullName()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
        }
        class Student : Human
        {
            public void PrintWork()
            {
                Console.WriteLine("Я учусь!");
            }
        }
        class Employee : Human
        {
            public void PrintWork()
            {
                Console.WriteLine("Я работаю!");
            }
        }
        class Point2D
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point2D(int x, int y)
            {
                X = x;
                Y = y;
                Console.WriteLine("Вызван конструктор класса Point2D");
            }
            public void Print2D()
            {
                Console.WriteLine("X:\t"  +X);
                Console.WriteLine("Y:\t"  +Y);
            }
        }
        class Point3D : Point2D
        {
            public int Z { get; set; }
            public Point3D(int x, int y, int z):base(x,y)
            {
                Z = z;
                Console.WriteLine("Вызван конструктор класса Point3D");
            }
            public void Print3D()
            {
                Print2D();
                Console.WriteLine("Z:\t"  +Z);
            }
        }
        class A
        {
            public int publicField;
            private int privateField;
            protected int protectedField;
            public A()
            {
                Console.WriteLine(publicField); //Поле доступно
                Console.WriteLine(privateField); //Поле доступно
                Console.WriteLine(protectedField); //Поле доступно
            }
            public void foo()
            {
                Console.WriteLine(publicField); //Поле доступно
                Console.WriteLine(privateField); //Поле доступно
                Console.WriteLine(protectedField); //Поле доступно
            }

        }
        class B : A
        {
            public B()
            {
                Console.WriteLine(publicField);    //Поле доступно
                //Console.WriteLine(privateField); //Поле не доступно, т.к. прямой доступ к нему имеет только
                                                   //тот класс, где написанно данное поле
                Console.WriteLine(protectedField); //Поле доступно

            }
            public void bar()
            {
                foo();
            }
        }
        class Car
        {
            protected virtual void StartEngine()
            {
                Console.WriteLine("Двигатель запущен!");
            }
            //Чтобы переопределить какой-то метод в базовом классе, у этого метода должен быть модификатор
            //virtual
            public virtual void Drive() //виртуальный метод
            {
                StartEngine();
                Console.WriteLine("Я машина, я еду!");
            }
        }
        class Driver
        {
            public void Drive(Car car)
            {
                car.Drive();
            }
        }
        class SportCar : Car
        {
            protected override void StartEngine()
            {
                Console.WriteLine("бу бу бу бу ан ан ан");
            }
            //Для переопределения метода, сигнатура переопределяющего метода должна быть идентичной
            //сигнатуре переопределяемого метода
            public override void Drive()
            {
                StartEngine();
                Console.WriteLine("Я еду очень быстро");
            }
        }

        interface IHasInfo
        {
            void ShowInfo();
        }
        interface IWeapon
        {
            int Damage { get; }
            void Fire();
        }

        abstract class Weapon : IHasInfo, IWeapon //Реализация интерфейсов
        {
            public abstract int Damage { get; }
            public abstract void Fire();
            public void ShowInfo()
            {
                Console.WriteLine($"{GetType().Name} Damage: {Damage}");
            }
        }
        class Pistol : Weapon
        {
            public override int Damage { get { return 5; } }

            //Ключевое слово override работает для переопределения виртуальных методов
            //и для переопределения абстрактных методов
            public override void Fire()
            {
                Console.WriteLine("Пау пау пау");
            }
        }
        class MachineGun : Weapon
        {
            public override int Damage => 20;

            public override void Fire()
            {
                Console.WriteLine("Тратататта");
            }
        }
        class GrenadeLauncher : Weapon
        {
            public override int Damage { get { return 100; } }

            public override void Fire()
            {
                Console.WriteLine("Фшшшшшшшшшш     БАМ!!!");
            }
        }
        class Player
        {
            public void Fire(IWeapon weapon)
            {
                weapon.Fire();
            }
            public void CheckInfo(IHasInfo hasInfo)
            {
                hasInfo.ShowInfo();
            }
        }
        class Box : IHasInfo
        {
            public void ShowInfo()
            {
                Console.WriteLine("Просто коробка");
            }
        }

        interface IDataProvider
        {
            //Все поля в интерфейсе заведомо public 
            string GetData();
        }
        interface IDataProcessor
        {
            void ProcessData(IDataProvider dataProvider);
        }
        class ConsoleDataProcessor : IDataProcessor
        {
            public void ProcessData(IDataProvider dataProvider)
            {
                Console.WriteLine(dataProvider.GetData());
            }
        }
        class DbDataProvider : IDataProvider
        {
            public string GetData()
            {
                return "Данные из базы данных";
            }
        }
        class FileDataProvider : IDataProvider
        {
            public string GetData()
            {
                return "Данные из файла";
            }
        }
        class ApiDataProvider : IDataProvider
        {
            public string GetData()
            {
                return "Данные из API";
            }
        }

        interface IWeapon1
        {
            void Fire();
        }
        interface IThrowingWeapon : IWeapon1
        {
            void Throw();
        }
        class Gun1 : IWeapon1
        {
            public void Fire()
            {
                Console.WriteLine($"{GetType().Name}: Паф!");
            }
        }
        class LaserGun1 : IWeapon1
        {
            public void Fire()
            {
                Console.WriteLine($"{GetType().Name}: Пиу!");
            }
        }
        class Knife : IThrowingWeapon
        {
            public void Fire()
            {
                Console.WriteLine($"{GetType().Name}: Хыщ!");
            }
            public void Throw()
            {
                Console.WriteLine($"{GetType().Name}: Фъють!");
            }
        }
        class Player1
        {
            public void Fire(IWeapon1 weapon1)
            {
                weapon1.Fire();
            }
            public void Throw(IThrowingWeapon throwingWeapon)
            {
                throwingWeapon.Throw();
            }
        }

        interface IFirstInterface
        {
            void Action();
        }
        interface ISecondInterface
        {
            void Action();
        }
        static void Foo(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }
        static void Bar(ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }
        class YouClass : IFirstInterface, ISecondInterface
        {
            public void Action()
            {
                Console.WriteLine("YouClass action");
            }
        }
        class YouOtherClass : IFirstInterface, ISecondInterface
        {
            //Явная реализация для интерфейса IFirstInterface
            void IFirstInterface.Action()
            {
                Console.WriteLine("YouOtherClass IFirstInterface.Action()");
            }

            //Явная реализация для интерфейса ISecondInterface
            void ISecondInterface.Action()
            {
                Console.WriteLine("YouOtherClass ISecondInterface.Action()");
            }
        }
    }
}
