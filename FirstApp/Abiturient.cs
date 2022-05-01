using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    sealed class Abiturient
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
    }

    /*class MyClass : Abiturient    //Мы не можем унаследоваться от класса Абитуриент, т.к. 
    //абитуриент с ключевым словом sealed
    {

    }*/
}
