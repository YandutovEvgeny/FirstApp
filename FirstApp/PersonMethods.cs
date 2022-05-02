using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    partial class Person
    {
        //разделение на partial методы работает только в C# 9.0 и выше
        /*public partial string GetFullName()
        {
            return FirstName + " " + LastName;
        }*/
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
    }
}
