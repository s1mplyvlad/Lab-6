using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Student : Persona
    {

        public Student()
        {

        }

        public Student(double yofbirth, string surname, string faculty, double grade)
        {

            Yofbirth = yofbirth;
            Surname = surname;
            Grade = grade;
            Faculty = faculty;
        }

        public double Yofbirth { get; private set; }

        public string Surname { get; private set; }
        public string Faculty { get; private set; }
        public double Grade { get; private set; }


        public override void CalculationAge()
        {

            Age = 2019 - (Yofbirth);

        }

        public override void OutputInformation()
        {

            Console.WriteLine("Студент : ");

            Console.WriteLine("Фамилия : {0}", Surname);

            Console.WriteLine("Год рождения : {0}", Yofbirth);

            Console.WriteLine("Факультет : {0}", Faculty);

            Console.WriteLine("Курс : {0}", Grade);

            base.OutputInformation();

            Console.WriteLine();

        }

    }

}
