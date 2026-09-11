namespace RPSGame;

public class InputValidation
{
    public static bool IsPositiveNumber(int number)
    {
        if (number > 0)
        {
            return true;
        }

        Console.WriteLine("Must be a positive number.");
        return false;
    }
}
