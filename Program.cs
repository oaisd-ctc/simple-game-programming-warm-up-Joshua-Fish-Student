public class Program{
    public static int rivalRoll;
    public static int playerRoll;
    public static Random minecraft = new Random();
    public static int playerWins = 0;
    public static int rivalWins = 0;
    public static void Main(string[] args){
        Console.Clear();
        Console.WriteLine("Dice Game");
        Console.WriteLine();
        Console.WriteLine("In this game you and a computer Rival will play 10 rounds \nwhere you will each roll a 6-sided dice, and the player \nwith the highest dice value will win the round. The player \nwho wins the most rounds wins the game. Good luck!");
        Console.WriteLine();
        Console.Write("Press any key to start...");
        Console.ReadKey();
        Console.WriteLine();
        for(int i = 1; i < 11; i++){
            Console.WriteLine();
            Console.WriteLine($"Round {i}");
            rivalRoll = minecraft.Next(1,7);
            Console.WriteLine($"Rival rolled a {rivalRoll}");
            Console.Write("Press any key to roll the die...");
            Console.ReadKey();
            Console.WriteLine();
            playerRoll = minecraft.Next(1,7);
            Console.WriteLine($"You rolled a {playerRoll}");
            if(rivalRoll < playerRoll){
                Console.WriteLine("You won this round.");
                playerWins += 1;
            } else if(rivalRoll > playerRoll){
                Console.WriteLine("The Rival won this round.");
                rivalWins += 1;
            } else{Console.WriteLine("This round is a draw!");}
            Console.WriteLine($"The score is now - You : {playerWins}. Rival : {rivalWins}.");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine($"Game over.\nThe score is now - You : {playerWins}. Rival : {rivalWins}.");
        if(playerWins > rivalWins){Console.WriteLine("You won!");}
        else if(playerWins < rivalWins){Console.WriteLine("You lost!");}
        else{Console.WriteLine("The game is a draw.");}
        Console.Write("Press any key to exit...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Dice Game was closed.");
    }
}