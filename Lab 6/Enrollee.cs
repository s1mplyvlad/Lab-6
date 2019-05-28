using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Enrollee : Persona
    {

        public Enrollee()
        {

        }

        public Enrollee(double yofbirth, string surname, string faculty)
        {

            Yofbirth = yofbirth;
            Surname = surname;
            Faculty = faculty;

        }


        public double Yofbirth { get; private set; }

        public string Surname { get; private set; }
        public string Faculty { get; private set; }


        public override void CalculationAge()
        {

            Age = 2019 - (Yofbirth);

        }


        public override void OutputInformation()
        {

            Console.WriteLine("Абитуриент : ");

            Console.WriteLine("Фамилия : {0}", Surname);

            Console.WriteLine("Год рождения : {0}", Yofbirth);

            Console.WriteLine("Факультет : {0}", Faculty);

            base.OutputInformation();

            Console.WriteLine();

        }

    }

}
