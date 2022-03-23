using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Null_unitWF
{
    public partial class Form1 : Form
    {
        //List<Person> peoples;
        public Form1()
        {
            InitializeComponent();
            /*people = new List<Person>();
           
            Person Igor = new Person();
            Igor.FirstName = "Игорь";
            //Igor.SecondName = "Никандров";
            Igor.MiddleName = "Анатольевич";
            people.Add(Igor);

            Person Kostya = new Person();
            //Kostya.FirstName = "Костя";
            Kostya.SecondName = "Барабанов";
            Kostya.MiddleName = "Николаевич";
            people.Add(Kostya);

            Person Vika = new Person();
            Vika.FirstName = "Вика";
            Vika.SecondName = "Лукина";
            people.Add(Vika);*/
        }

        private List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person(){FirstName = "Игорь", SecondName = "Никандров", MiddleName = "Анатольевич"},
                new Person(){FirstName = "Костя", SecondName = "Барабанов"},
                new Person(){FirstName = "unknown"}
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //Очищает наш listbox
            var persons = GetPersons();
            /* foreach(Person person in people)
                 listBox1.Items.Add(person.GetNullName());*/
            foreach (var person in persons)
            {
                listBox1.Items.Add(person.GetFullName());
            }
            
        }
    }
}
