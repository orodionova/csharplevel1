using System;

/* 
Родионова О.В.
Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
	а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.
*/
namespace Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            var lastName = Console.ReadLine();
            Console.Write("Сколько вам лет: ");
            var age = Console.ReadLine();
            Console.Write("Ваш рост: ");
            var height = Console.ReadLine();
            Console.Write("Ваш вес: ");
            var weight = Console.ReadLine();
            var resultA = "Имя: " + name + "; Фамилия: " + lastName + "; Возраст: "
                + age + "; Рост: " + height + "; Вес: " + weight + ".";
            Console.WriteLine("Склеивание -");
            Console.WriteLine(resultA);
            Console.WriteLine("Форматированный вывод -");
            Console.WriteLine("Имя: {0}; Фамилия: {1}; Возраст: {2:G}; Рост: {3:G}; Вес: {4:G}.",
                name, lastName, age, height, weight);
            Console.WriteLine("Используя вывод со знаком $ -");
            Console.WriteLine($"Имя: {name}; Фамилия: {lastName}; Возраст: {age}; Рост: {height}; Вес: {weight}.");
            Console.ReadLine();
        }
    }
}
