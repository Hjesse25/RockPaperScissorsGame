namespace RPSGame.UserCommunication;

public class ConsoleReader
{
    public static int ReadInteger(string message)
    {
        int number;
        do
        {
            Console.WriteLine(message);
        } while (!int.TryParse(Console.ReadLine(), out number));
        return number;
    }

    public static void ReadKey(string message)
    {
        Console.WriteLine(message);
        Console.ReadKey();
    }
}
