using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.SetWindowSize(150, 45);
            List<Student> students = new List<Student>();
            Console.Write("Въведи колко ученика има: ");
            int count = int.Parse(Console.ReadLine());
            // Въвеждане на данни за ученици
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Въведете данни за ученик {i + 1}:");
                students.Add(StudentBase.InputStudentData());
            }

            // Извеждане на данните за учениците
            Console.WriteLine("Данни за учениците:");
            foreach (var student in students)
            {
                student.DisplayStudent();
            }

            // Извеждане на учениците, които имат право на стипендия
            Console.WriteLine("Ученици, които имат право на стипендия:");
            var scholarshipStudents = students.Where(s => !s.HasPenalty && s.Grade >= 4.00 && s.AverageIncomePerMember() <= 1200); // Примерно условие за среден доход
            foreach (var student in scholarshipStudents)
            {
                student.DisplayStudent();
            }

            // Изчисляване на средния успех на учениците
            double averageGrade = students.Average(s => s.Grade);
            Console.WriteLine($"Среден успех на учениците: {averageGrade}");

            // Извеждане на данните за ученика с най-висок успех
            var topStudent = students.OrderByDescending(s => s.Grade).First();
            Console.WriteLine("Ученик с най-висок успех:");
            topStudent.DisplayStudent();

            // Сортиране на данните по възходящ среден месечен доход на член от семейството
            var sortedStudents = students.OrderBy(s => s.AverageIncomePerMember()).ToList();
            Console.WriteLine("Ученици, сортирани по възходящ среден месечен доход на член от семейството:");
            foreach (var student in sortedStudents)
            {
                student.DisplayStudent();
            }

            // Записване на данните във файл
            const string filePath = "students.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var student in students)
                {
                    writer.WriteLine($"{student.Name},{student.Class},{student.Section},{student.FamilyIncome},{student.OtherIncome},{student.FamilyMembers},{student.Grade},{student.HasPenalty}");
                }
            }
            Console.WriteLine($"Данните са записани във файл {filePath}");
        }
    }
}
