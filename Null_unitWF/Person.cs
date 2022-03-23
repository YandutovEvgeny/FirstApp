using System;
using System.Collections.Generic;
using System.Text;

namespace Null_unitWF
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }

        public string GetFullName()
        {
            //Или так:
            return $"Фамилия: {SecondName ?? "Нет данных" } | Имя: {FirstName ?? "Нет данных"} | Отчество: {MiddleName ?? "Нет данных"}";
            /*Или так, но с каждым:
            if(MiddleName == null)
                return $"Фамилия: {SecondName} | Имя: {FirstName} | Отчество: Нет данных";
            else
                return $"Фамилия: {SecondName} | Имя: {FirstName} | Отчество: {MiddleName}";*/
        }
        
}
}
