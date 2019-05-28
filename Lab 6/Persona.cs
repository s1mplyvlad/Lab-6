using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    abstract class Persona
    {

        protected double Age { get; set; }

        public abstract void CalculationAge();

        public virtual void OutputInformation()
        {

            Console.WriteLine("Возраст = ", Age);

        }

    }

}
