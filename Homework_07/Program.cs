using System;

    internal class Program
{
    static void Main(string[] args)
    {
        string userMessage;
        int numberOfMessages;

        Console.WriteLine("Введите слово, которое выведет консоль: ");
        userMessage = Console.ReadLine();
        Console.WriteLine("Сколько раз консоль выведет слово: ");
        numberOfMessages = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numberOfMessages; i++)
        {
            Console.WriteLine(userMessage);
        }
    }
}