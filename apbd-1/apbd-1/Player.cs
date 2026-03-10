namespace apbd_1
{
    public class Player
    {
        public Choice currentChoice = Choice.None;

        public Player() {}

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
    }
}
