using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Teacher : Persona
    {

        public Teacher()
        {

        }

        public Teacher(double yofbirth, string surname, string faculty, string position, double exp)
        {

            Yofbirth = yofbirth;
            Surname = surname;
            Faculty = faculty;
            Position = position;
            Exp = exp;
        }


        public double Yofbirth { get; set; }

        public string Surname { get; private set; }
        public string Faculty { get; private set; }
        public string Position { get; private set; }
        public double Exp { get; private set; }

        public override void CalculationAge()
        {

            Age = 2019 - (Yofbirth);

        }

        public override void OutputInformation()
        {

            Console.WriteLine("Преподаватель : ");

            Console.WriteLine("Фамилия : {0}", Surname);

            Console.WriteLine("Год рождения : {0}", Yofbirth);

            Console.WriteLine("Факультет : {0}", Faculty);

            Console.WriteLine("Посада : {0}", Position);

            Console.WriteLine("Стаж : {0}", Exp);

            base.OutputInformation();

            Console.WriteLine();

        }

    }

}
