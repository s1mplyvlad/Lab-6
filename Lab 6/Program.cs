using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                StreamReader input = new StreamReader("information.txt");

                int countPersons = Convert.ToInt32(input.ReadLine());

                Console.WriteLine("Количество возможных персон - {0}\n", countPersons);

                Persona[] person = new Persona[countPersons];

                int i = 0;

                while (i != countPersons)
                {

                    Console.WriteLine("Введите одну из трьох цифр для нахождения возраста персоны :");

                    Console.WriteLine("1 - Абитуриент\n2 - Студент\n3 - Преподаватель");

                    string numeral = Console.ReadLine();

                    if (numeral == "1")
                    {

                        Console.WriteLine("Введите год рождения абитуриента : ");

                        double yofbirth = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Введите фамилию абитуриента : ");

                        string surname = Console.ReadLine();

                        Console.WriteLine("Введите факультет абитуриента : ");

                        string faculty = Console.ReadLine();

                        person[i] = new Enrollee(yofbirth, surname, faculty);

                        person[i].CalculationAge();

                        person[i].OutputInformation();

                        i++;

                    }
                    else if (numeral == "2")
                    {

                        Console.WriteLine("Введите год рождения студента : ");

                        double yofbirth = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Введите фамилию студента : ");

                        string surname = Console.ReadLine();

                        Console.WriteLine("Введите факультет студента : ");

                        string faculty = Console.ReadLine();

                        Console.WriteLine("Введите курс студента : ");

                        double grade = Convert.ToDouble(Console.ReadLine());

                        person[i] = new Student(yofbirth, surname, faculty, grade);

                        person[i].CalculationAge();

                        person[i].OutputInformation();

                        i++;

                    }
                    else if (numeral == "3")
                    {

                        Console.WriteLine("Введите год рождения преподавателя : ");

                        double yofbirth = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Введите фамилию преподавателя : ");

                        string surname = Console.ReadLine();

                        Console.WriteLine("Введите факультет преподавателя : ");

                        string faculty = Console.ReadLine();

                        Console.WriteLine("Введите должность преподавателя : ");

                        string position = Console.ReadLine();

                        Console.WriteLine("Введите стаж преподавателя : ");

                        double exp = Convert.ToDouble(Console.ReadLine());

                        person[i] = new Teacher(yofbirth, surname, faculty, position, exp);

                        person[i].CalculationAge();

                        person[i].OutputInformation();

                        i++;

                    }
                    else
                    {

                        Console.WriteLine("Данной команды не существует!");

                        Console.WriteLine();

                    }

                }

                input.Close();

            }
            catch (OverflowException ex)
            {

                string message = ex.Message;

                Console.WriteLine(message);


            }
            catch (FormatException ex)
            {

                string message = ex.Message;

                Console.WriteLine(message);

            }
            catch (FileNotFoundException ex)
            {

                string message = ex.Message;

                Console.WriteLine(message);

            }

        
        }
    }
}
