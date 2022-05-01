using System;
using Lesson_2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_MyExtensions
{
    static class MyExtensions
    {
        //первым параметром всегда идёт тот тип данных с ключевым словом this для которого мы пишем метод расширения
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }

        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }
    }
}

namespace Lesson2_MyExtensions
{
    static class MyExtensions
    {
        public static string GetFullName(this Abiturient abiturient)
        {
            return abiturient.FirstName + " " + abiturient.lastName;
        }
    }
}