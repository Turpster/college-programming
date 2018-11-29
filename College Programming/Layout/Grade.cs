using System;

namespace Selection.Papers
{
    public static class Grade
    {
        public enum GradeType
        {
            U = 0,
            E = 40,
            D = 50,
            C = 60,
            B = 70,
            A = 80
        }

        public static char ToChar(GradeType grade)
        {
            switch (grade)
            {
                case GradeType.A:
                    return 'A';
                case GradeType.B:
                    return 'B';
                case GradeType.C:
                    return 'C';
                case GradeType.D:
                    return 'D';
                case GradeType.E:
                    return 'E';
                default:
                    return 'U';
            }
        }
        
        public static GradeType ToGrade(char gradeChr)
        {
            switch (gradeChr)
            {
                case 'U':
                    return GradeType.U;
                case 'E':
                    return GradeType.E;
                case 'D':
                    return GradeType.D;
                case 'C':
                    return GradeType.C;
                case 'B':
                    return GradeType.B;
                case 'A':
                    return GradeType.A;
                default:
                    throw new FormatException("Invalid Grade");
            }
        }

        public static GradeType ToGrade(int marks)
        {
            if (marks < (int) GradeType.E)
            {
                return GradeType.U;
            }
            if (marks < (int) GradeType.D)
            {
                return GradeType.E;
            }
            if (marks < (int) GradeType.C)
            {
                return GradeType.D;
            }
            if (marks < (int) GradeType.B)
            {
                return GradeType.C;
            }
            if (marks < (int) GradeType.A)
            {
                return GradeType.B;
            }
            return GradeType.A;
        }
    }
}