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
//#define VALUETYPES_REFERENCETYPES
//#define NULL_NULLUNIT


using System;
using System.Globalization;
using System.Threading;
using System.Linq;          //Позволяет раюотать с классом Array

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
            /*string result = str ?? string.Empty;    //В результат либо str, либо Empty, если null
            Console.WriteLine("Количество символов с строке " + result.Length);*/

            //Оператор присваивания объединения со значением Null ??=
            /*string str = null;
            str ??= "default string";
            Console.WriteLine("количество символов в строке: " + str.Length);*/

            /*int[] array = null;
            array ??= new int[0];
            Console.WriteLine("количество элементов в массиве " + array.Length);*/ 
#endif

        }
        
    }
    
}
