using System;
using System.Globalization;

namespace StudentGradesByQuarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Nome do aluno: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            student.FirstGrade = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.SecondGrade = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.ThirdGrade = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(student);
        }
    }
}
