using RoshamboLab;
using RoshamboLab.Players;

Console.Write("Welcome to Rock Paper Scissors!\n" +
    "Enter your name: ");

string playerName = Console.ReadLine();
HumanPlayer player1 = new HumanPlayer(playerName);

string playerChoice;
bool isValidOpponent = false;
do
{
	Console.Write("\nWho would you like to play against?\n" +
"Mysterio or Brock (m/b)? ");

	playerChoice = Console.ReadLine().ToLower();
	isValidOpponent = Validation.ConfirmOpponent(playerChoice); 

	if (isValidOpponent == false)
	{
		Console.WriteLine("\nI'm sorry, that is not a valid entry. Please select again.");
	}
} while (isValidOpponent == false);


Player player2;
if (playerChoice == "m")
{
	player2 = new RandomPLayer();
}
else
{
	player2 = new RockPlayer();
}

int wins = 0;
int losses = 0;
string playerRepeat = null;
bool replay = true;

do
{
	Console.WriteLine();

	player1.GenerateRoshambo();
	player2.GenerateRoshambo();

	Console.WriteLine();

	Console.WriteLine($"{player1.Name}: {player1.Value}\n" +
		$"{player2.Name}: {player2.Value}");

	if (player1.Value == Roshambo.Rock)
	{
		if (player2.Value == Roshambo.Scissors)
		{
			Console.WriteLine(player1.Name + " wins!");
			wins++;
		}
		else if (player2.Value == Roshambo.Rock)
		{
			Console.WriteLine("Draw!");
		}
		else
		{
			Console.WriteLine(player2.Name + " wins!");
			losses++;
		}
	}
	else if (player1.Value == Roshambo.Paper)
	{
		if (player2.Value == Roshambo.Rock)
		{
			Console.WriteLine(player1.Name + " wins!");
			wins++;
		}
		else if (player2.Value == Roshambo.Paper)
		{
			Console.WriteLine("Draw!");
		}
		else
		{
			Console.WriteLine(player2.Name + " wins!");
			losses++;
		}
	}
	else if (player1.Value == Roshambo.Scissors)
	{
		if (player2.Value == Roshambo.Paper)
		{
			Console.WriteLine(player1.Name + " wins!");
			wins++;
		}
		else if (player2.Value == Roshambo.Paper)
		{
			Console.WriteLine("Draw!");
		}
		else
		{
			Console.WriteLine(player2.Name + " wins!");
			losses++;
		}
	}

	Console.WriteLine($"Wins: {wins} / Losses: {losses}");

	bool isValidAnswer = false;
	do
	{
		Console.WriteLine();
		Console.Write("Play again (y/n)? ");
		playerRepeat = Console.ReadLine().ToLower();
		isValidAnswer = Validation.ConfirmYN(playerRepeat);

		if (isValidAnswer == false)
		{
			Console.WriteLine("I'm sorry, that is not a valid response. Please try again.");
		}
	} while (isValidAnswer == false);

	if (playerRepeat == "y")
	{
		replay = true;
	}
	else if (playerRepeat == "n")
	{
		replay = false;
	} 
} while (replay == true);

Console.WriteLine("\nGoodbye!");