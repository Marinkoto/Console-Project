using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Student : StudentBase
    {
        public string Section { get; set; }
        public double FamilyIncome { get; set; }
        public double OtherIncome { get; set; }
        public int FamilyMembers { get; set; }
        public double Grade { get; set; }
        public bool HasPenalty { get; set; }
        public override double AverageIncomePerMember()
        {
            return (FamilyIncome + OtherIncome) / FamilyMembers;
        }

        public override void DisplayStudent()
        {
            Console.WriteLine($"Name: {Name}, Class: {Class}, Section: {Section}, Family Income: {FamilyIncome}, Other Income: {OtherIncome}, Family Members: {FamilyMembers}, Grade: {Grade:f2}, Has Penalty: {HasPenalty}");
        }

        public Student(string name, int studentClass, string section, double familyIncome, double otherIncome, int familyMembers, double grade, bool hasPenalty) : base(name,studentClass)
        {
            Section = section;
            FamilyIncome = familyIncome;
            OtherIncome = otherIncome;
            FamilyMembers = familyMembers;
            Grade = grade;
            HasPenalty = hasPenalty;
        }
    }
}
