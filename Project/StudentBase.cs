using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public abstract class StudentBase : IStudent
    {
        public string Name { get; set; }
        public int Class { get; set; }

        public abstract double AverageIncomePerMember();
        public abstract void DisplayStudent();
        public static Student InputStudentData()
        {
            try
            {
                Console.Write("Име: ");
                string name = Console.ReadLine();
                Console.Write("Клас: ");
                int studentClass = int.Parse(Console.ReadLine());
                Console.Write("Паралелка: ");
                string section = Console.ReadLine();
                Console.Write("Доход на семейството от заплати: ");
                double familyIncome = double.Parse(Console.ReadLine());
                Console.Write("Други доходи за периода: ");
                double otherIncome = double.Parse(Console.ReadLine());
                Console.Write("Брой членове на семейството: ");
                int familyMembers = int.Parse(Console.ReadLine());
                Console.Write("Успех от предходната учебна година (срок): ");
                double grade = double.Parse(Console.ReadLine());
                Console.Write("Наказания (да/не): ");
                bool hasPenalty = Console.ReadLine().ToLower() == "да";

                return new Student(name, studentClass, section, familyIncome, otherIncome, familyMembers, grade, hasPenalty);
            }
            catch (FormatException)
            {
                Console.WriteLine("Грешка във входните данни. Моля, опитайте отново.");
                return InputStudentData();
            }
        }
        public StudentBase(string name,int @class)
        {
            this.Name = name;
            this.Class = @class;
        }
    }
}
