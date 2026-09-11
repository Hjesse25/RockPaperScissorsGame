using RPSGame.UserCommunication;

namespace RPSGame.Game;

public class RockPaperScissorsGame(Dice dice)
{
    private readonly Dice _dice = dice;
    private int _numberOfRounds = 0;

    public void Play()
    {
        StartMenu();
        // TODO: Implement game logic
    }

    public static void PrintResult(GameResult gameResult)
    {
        string message;
        if (gameResult == GameResult.Victory)
        {
            message = "You won!";
        }
        else if (gameResult == GameResult.Loss)
        {
            message = "You lost.";
        }
        else
        {
            message = "Tie game.";
        }

        Console.WriteLine(message);
    }

    private void StartMenu()
    {
        Console.WriteLine("Welcome to the Rock, Paper, Scissors Game");
        GetNumberOfRounds();
        ConsoleReader.ReadKey("Press any key to continue...");
    }

    private void GetNumberOfRounds()
    {
        bool isValid = false;
        int rounds;
        do
        {
            rounds = ConsoleReader.ReadInteger("Enter the number of rounds you want to play:");
            bool isPositiveNumber = InputValidation.IsPositiveNumber(rounds);

            if (!isPositiveNumber)
            {
                continue;
            }
            else
            {
                _numberOfRounds = rounds;
                isValid = true;
            }


        } while (!isValid);


    }
}
