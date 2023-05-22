using System;

namespace EducationlSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation(); //Виклик методу для збору інформації про студента;
            TeacherInformation(); //Виклик методу для збору інформації про педагога
            UniversityInformation(); //Виклик методу для збору інформації про університет;

            //Закінчити програму
            Console.WriteLine("Натисніть будь-яку клавішу для завершення роботи.");
            Console.ReadKey();
        }

        static void StudentInformation()
        {
            // Дані студента

            // Заголовок
            Console.WriteLine("Інформація про студента:");

            // Дії
            Console.WriteLine("");
            Console.WriteLine("Введіть своє прізвище та ім'я:");
            string studentName = Console.ReadLine();

            Console.WriteLine("Введіть свій вік:");
            int studentAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Напишіть назву навчального закладу:");
            string universityName = Console.ReadLine();

            Console.WriteLine("Введіть назву вашого факультету: ");
            string facultyName = Console.ReadLine();

            Console.WriteLine("Введіть свій середній бал:");
            double averageGrade = Convert.ToDouble(Console.ReadLine());

            //Заповнена анкета
            Console.WriteLine("");
            Console.WriteLine("Дані студента:");
            Console.WriteLine("Ім'я: " + studentName);
            Console.WriteLine("Вік: " + studentAge);
            Console.WriteLine("Навчальний заклад: " + universityName);
            Console.WriteLine("Факультет:" + facultyName);
            Console.WriteLine("Середній бал: " + averageGrade);
        }

        static void TeacherInformation()
        {
            // Дані педагога

            // Заголовок
            Console.WriteLine("");
            Console.WriteLine("Інформація про педагога:");
            Console.WriteLine("");

            // Дії
            Console.WriteLine("Введіть своє прізвище та ім'я:");
            string teacherName = Console.ReadLine();

            Console.WriteLine("Введіть свій вік:");
            int teacherAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Напишіть назву навчального закладу, де працюєте:");
            string schoolName = Console.ReadLine();

            Console.WriteLine("Введіть предмет, який викладаєте (можна декілька):");
            string subject = Console.ReadLine();

            //Заповнена анкета
            Console.WriteLine("");
            Console.WriteLine("Дані педагога:");
            Console.WriteLine("Ім'я: " + teacherName);
            Console.WriteLine("Вік: " + teacherAge);
            Console.WriteLine("Навчальний заклад: " + schoolName);
            Console.WriteLine("Предмет:" + subject);


        }

        static void UniversityInformation()
        {
            //Дані про університет

            // Заголовок
            Console.WriteLine("");
            Console.WriteLine("Інформація про університет:");
            Console.WriteLine("");

            //Дії
            Console.WriteLine("Введіть назву університету:");
            string universityName = Console.ReadLine();

            Console.WriteLine("Введіть рік заснування університету:");
            int yearFounded = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чи працює університет? (введіть true або false):");
            bool isWorking = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Скільки студентів навчається в університеті:");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Скільки вчителів працює в університеті:");
            int numberOfTeachers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чи є університет державним? (введіть true або false):");
            bool isPublic = Convert.ToBoolean(Console.ReadLine());

            //Заповнена анкета
            Console.WriteLine("");
            Console.WriteLine("Дані про університет:");
            Console.WriteLine("Назва: " + universityName);
            Console.WriteLine("Рік заснування: " + yearFounded);
            Console.WriteLine("Чи працює: " + isWorking);
            Console.WriteLine("Кількість студентів: " + numberOfStudents);
            Console.WriteLine("Кількість вчителів: " + numberOfTeachers);
            Console.WriteLine("Державний: " + isPublic);
        }
    }


}


       



       