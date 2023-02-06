using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public List<int> points= new List<int>();


        Random rng = new Random();

        public Employee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void AddPointsToEmployee(int score)
        {
            points.Add(score);
        }
        public void AddRandomPointsToEmployee()
        {
            AddPointsToEmployee(rng.Next(1, 11));
        }

        public void ShowThePointsOfEmp()
        {
            foreach (var i in points)
            {
                Console.WriteLine(i.ToString());
            }
            Console.Write("Suma: ");
            Console.WriteLine(SumOfPointsOfEmployee());
            Console.WriteLine();
        }

        public int SumOfPointsOfEmployee()
        {
            return points.Sum();
        }

    }
}