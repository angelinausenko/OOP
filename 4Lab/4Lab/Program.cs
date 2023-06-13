using System;

namespace EducationlSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введіть своє ім'я:");
            string studentName = Console.ReadLine();

            Console.WriteLine("Введіть свій вік:");
            int studentAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть свій середній бал:");
            double averageGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть статус зарахування (True або False):");
            bool isEnrolled = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Інформація про студента:");
            Console.WriteLine("Ім'я: " + studentName);
            Console.WriteLine("Вік: " + studentAge);
            Console.WriteLine("Середній бал: " + averageGrade);
            Console.WriteLine("Статус зарахування: " + isEnrolled);

            Console.WriteLine("Статичні дані:");
            Console.WriteLine("Кількість студентів: " + Student.Count);
            Console.WriteLine("Максимальний бал: " + Student.MaxGrade);

            Console.WriteLine();

            Console.WriteLine("Введіть ім'я педагога: ");
            string teacherName = Console.ReadLine();

            Console.WriteLine("Введіть предмет, який викладає педагог: ");
            string subject = Console.ReadLine();

            Console.WriteLine("Введіть рік початку роботи педагога: ");
            int startYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Інформація про педагога: ");
            Console.WriteLine("ім'я: " + teacherName);
            Console.WriteLine("Предмет: " + subject);
            Console.WriteLine("Рік початку роботи: " + startYear);

            Console.WriteLine("Статичні дані: ");
            Console.WriteLine("кількість вчителів: " + Teacher.Count);

            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadKey();


        }

        class Student
        {
            private string name;
            private int age;
            private double averageGrade;
            private bool isEnrolled;

            public static int Count { get; private set; }
            public static double MaxGrade { get; set; }

            public string GetName()
            {
                return name;
            }

            public void SetName(string value)
            {
                name = value;
            }

            public int GetAge()
            {
                return age;
            }

            public void SetAge(int value)
            {
                age = value;
            }

            public double GetAverageGrade()
            {
                return averageGrade;
            }

            public void SetAverageGrade(double value)
            {
                averageGrade = value;
            }

            public bool GetIsEnrolled()
            {
                return isEnrolled;
            }

            public void SetIsEnrolled(bool value)
            {
                isEnrolled = value;
            }



        }

        class Teacher
        {
            private string name;
            private string subject;
            private int startYear;

            public static int Count { get; private set; }

            public string GetName()
            {
                return name;
            }

            public void SetName(string value)
            {
                name = value;
            }

            public string GetSubject()
            {
                return subject;
            }

            public void SetSubject(string value)
            {
                subject = value;
            }

            public int GetStartYear()
            {
                return startYear;
            }

            public void SetStartYear(int value)
            {
                startYear = value;
            }


        }
          

        
    }


}


       



       