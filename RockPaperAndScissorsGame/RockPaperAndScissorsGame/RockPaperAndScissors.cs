using System.Media;
const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

//Choosing player move
Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
string playerMove = Console.ReadLine();

if (playerMove == "r"|| playerMove == "rock")
{
    playerMove = Rock;
}
else if (playerMove == "p" || playerMove == "paper")
{
    playerMove = Paper;
}
else if (playerMove == "s" || playerMove == "scissors")
{
    playerMove = Scissors;
}
else
{
    Console.WriteLine("Don't be stupid ! Choose valid input !");
    return;
}

//Choosing computer move
Random computerRandomNumber = new Random(); 
int randomComputerNumber = computerRandomNumber.Next(1,4);

string computerMove = "";
switch(randomComputerNumber)
{
    case 1:
        computerMove = Rock;
        break;
    case 2:
        computerMove = Paper;
        break;
    case 3:
        computerMove = Scissors;
        break;
}

Console.WriteLine($"The computer choose {computerMove}.");

//Choosing the winner 
if (playerMove == Rock && computerMove == Scissors ||
    playerMove == Paper && computerMove == Rock ||
    playerMove == Scissors && computerMove == Paper)
{
    Console.WriteLine("You win !");
    SoundPlayer win = new SoundPlayer("Win.wav");
    win.PlaySync();
}
else if (playerMove == Scissors && computerMove == Rock || 
    playerMove == Rock && computerMove == Paper ||
    playerMove == Paper && computerMove == Scissors)
{
    Console.WriteLine("You lose ! The computer win !");
    SoundPlayer lose = new SoundPlayer("Failed.wav");
    lose.PlaySync();
}
else
{
    Console.WriteLine("The game is draw.");
    SoundPlayer draw = new SoundPlayer("Love.wav");
    draw.PlaySync();
}