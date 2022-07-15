using System.Globalization;

namespace StudentGradesByQuarter
{
    public class Student
    {
        public string Name;
        public float FirstGrade;
        public float SecondGrade;
        public float ThirdGrade;

        public float FinalGrade()
        {
            return FirstGrade + SecondGrade + ThirdGrade;
        }

        public bool IsApproved()
        {
            if (FinalGrade() >= 60f) return true;

            return false;
        }

        public override string ToString()
        {
            if (IsApproved())
            {
                return $"NOTA FINAL = {FinalGrade().ToString("F2", CultureInfo.InvariantCulture)}\nAPROVADO";
            }
            else
            {
                return $"NOTA FINAL = {FinalGrade().ToString("F2", CultureInfo.InvariantCulture)}\nREPROVADO\nFALTAM {(60 - FinalGrade()).ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
            }
        }
    }
}
