using RPSGame.Game;

var random = new Random();
var dice = new Dice(random);
var game = new RockPaperScissorsGame(dice);

// GameResult gameResult = game.Play();
// RockPaperScissors.PrintResult(gameResult);