namespace NewC_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            string messageExite = "exite";

            Console.WriteLine($"Введите сообщение: ");
            message = Console.ReadLine();

            while (message != messageExite)
            { 
                Console.WriteLine($"Вы ввели: {message}; Для выхода введите - {messageExite}");
                Console.WriteLine($"Введите сообщение: "); 
                message = Console.ReadLine();
            }
        }
    }
}