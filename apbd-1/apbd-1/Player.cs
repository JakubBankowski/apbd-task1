namespace apbd_1
{
    public class Player
    {
        public int points = 0;

        public string name;

        public Choice currentChoice = Choice.None;

        public Player(string name) { this.name = name; }

        public void PickChoice()
        {
            string choice = Console.ReadLine();
            if (choice != "Rock" || choice != "Paper" || choice != "Scissors") Enum.TryParse(choice, true, out currentChoice);
            else
            {
                currentChoice = Choice.None;
                Console.WriteLine("Wrong choice.");
            }
        }

        public void CheckChoice(Player otherPlayer) {
            if (currentChoice == Choice.Rock) { 
                if (otherPlayer.currentChoice == Choice.Rock)
                {
                    Console.WriteLine("Draw round!");
                }
                else if (otherPlayer.currentChoice == Choice.Paper)
                {
                    Console.WriteLine(otherPlayer.name + " wins!");
                    this.points -= 1;
                    otherPlayer.points += 1;
                }
                else if (otherPlayer.currentChoice == Choice.Scissors)
                {
                    Console.WriteLine(this.name + " wins!");
                    this.points += 1;
                    otherPlayer.points -= 1;
                }
                else if (otherPlayer.currentChoice == Choice.None)
                {
                    Console.WriteLine(this.name + " wins!");
                    this.points += 1;
                    otherPlayer.points -= 1;
                }
            }
            else if (currentChoice == Choice.Paper)
            {
                if (otherPlayer.currentChoice == Choice.Paper)
                {
                    Console.WriteLine("Draw round!");
                }
                else if (otherPlayer.currentChoice == Choice.Scissors)
                {
                    Console.WriteLine(otherPlayer.name + " wins!");
                    this.points -= 1;
                    otherPlayer.points += 1;
                }
                else if (otherPlayer.currentChoice == Choice.Rock)
                {
                    Console.WriteLine(this.name + " wins!");
                    this.points += 1;
                    otherPlayer.points -= 1;
                }
                else if (otherPlayer.currentChoice == Choice.None)
                {
                    Console.WriteLine(this.name + " wins!");
                    this.points += 1;
                    otherPlayer.points -= 1;
                }
            }
            else if (currentChoice == Choice.Scissors)
            {
                if (otherPlayer.currentChoice == Choice.Scissors)
                {
                    Console.WriteLine("Draw round!");
                }
                else if (otherPlayer.currentChoice == Choice.Rock)
                {
                    Console.WriteLine(otherPlayer.name + " wins!");
                    this.points -= 1;
                    otherPlayer.points += 1;
                }
                else if (otherPlayer.currentChoice == Choice.Paper)
                {
                    Console.WriteLine(this.name + " wins!");
                    this.points += 1;
                    otherPlayer.points -= 1;
                }
                else if (otherPlayer.currentChoice == Choice.None)
                {
                    Console.WriteLine(this.name + " wins!");
                    this.points += 1;
                    otherPlayer.points -= 1;
                }
            }
            else if (currentChoice == Choice.None)
            {
                Console.WriteLine(otherPlayer.name + " wins!");
                this.points -= 1;
                otherPlayer.points += 1;
            }
        }
    }
}
