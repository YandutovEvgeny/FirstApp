using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Student
    {
        private Guid id;
        private string firstName;
        private string lastName;
        private string middleName;
        private int age;
        private string group;
        private DateTime birthday;
        public Student()
        {

        }
        public Student(string lastName, DateTime birthday)
        {
            this.lastName = lastName;
            this.birthday = birthday;
        }
        public Student(string lastName, string firstName, string middleName, DateTime birthday)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
            this.birthday = birthday;
        }
        public Student(Student student)
        {
            firstName = student.firstName;
            middleName = student.middleName;
            lastName = student.lastName;
            birthday = student.birthday;
        }
        public void SetLastname(string lastName)
        {
            this.lastName = lastName; 
        }
        public void Print()
        {
            Console.WriteLine("Info about student:");
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"first name: {firstName}");
            Console.WriteLine($"last name: {lastName}");
            Console.WriteLine($"middle name: {middleName}");
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"birthday: {birthday}");
            Console.WriteLine($"group: {group}");
        }
        public string GetFullName()
        {
            return $"{lastName} {firstName} {middleName}";
        }
    }
}
