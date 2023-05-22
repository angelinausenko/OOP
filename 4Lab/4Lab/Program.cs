namespace _4Lab;
class Student
{
    static void Main(string[] args)
    {
        //Навчальна система

        Console.WriteLine("Введіть своє прізвище та ім'я:");
        string studentName = Console.ReadLine();

        Console.WriteLine("Введіть свій вік:");
        int studentAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть свій середній бал:");
        double averageGrade = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Напишіть назву навчального закладу:");
        string universityName = Console.ReadLine();

        Console.WriteLine("Інформація про студента:");
        Console.WriteLine("Ім'я: " + studentName);
        Console.WriteLine("Вік: " + studentAge);
        Console.WriteLine("Середній бал: " + averageGrade);
        Console.WriteLine("Назва навчального закладу: " + universityName);

        Console.WriteLine("Натисніть будь-яку клавішу для завершення роюоти.");
        Console.ReadKey();





    }


}
