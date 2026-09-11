namespace RPSGame.Game;

public class Dice(Random random)
{
    private readonly Random _random = random;
    private const int Sides = 3;

    public int Roll => _random.Next(1, Sides + 1);
}
