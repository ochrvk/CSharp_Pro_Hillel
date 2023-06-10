class BlackJack
{

    private Player player;
    private Player computer;
    private Deck deck;
    private int playerWins;
    private int computerWins;
    private int draws;


    public void StartGame()
    {
        player = new Player();
        computer = new Player();
        deck = new Deck();

        deck.Mix();

        for (int i = 0; i < 2; i++)
        {
            player.Hand.Add(deck.Pop());
            computer.Hand.Add(deck.Pop());
        }

        Console.WriteLine("=====>Your hand<=====:");
        player.ShowHand();
        Console.WriteLine("=====>Computer's hand<=====:");
        computer.ShowHand();

        bool playerTurn = true;
        bool gameOver = false;

        while (!gameOver)
        {
            if (playerTurn)
            {
                Console.WriteLine("<=====Choose an option=====>:");
                Console.WriteLine("1. Hit");
                Console.WriteLine("2. Stand");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        player.Hand.Add(deck.Pop());
                        Console.WriteLine("=====>Your hand<=====:");
                        player.ShowHand();

                        if (player.Score > 21)
                        {
                            Console.WriteLine("Computer wins!");
                            computerWins++;
                            gameOver = true;
                        }
                        else if (player.Score == 21)
                        {
                            Console.WriteLine("You win!");
                            playerWins++;
                            gameOver = true;
                        }
                        break;

                    case "2":
                        playerTurn = false;
                        break;

                    default:
                        Console.WriteLine("Inсorrect type. Please try again.");
                        break;
                }
            }
            else
            {
                int computerScore = computer.Score;

                if (computerScore >= 17)
                {
                    Console.WriteLine("Computer stands.");
                    playerTurn = true;
                }
                else
                {
                    computer.Hand.Add(deck.Pop());
                    Console.WriteLine("=====>Computer's hand<=====:");
                    computer.ShowHand();

                    if (computer.Score > 21)
                    {
                        Console.WriteLine("You win!");
                        playerWins++;
                        gameOver = true;
                    }
                    else if (computer.Score == 21)
                    {
                        Console.WriteLine("Computer wins!");
                        computerWins++;
                        gameOver = true;
                    }
                }
            }
        }

        Console.WriteLine("Player wins: " + playerWins);
        Console.WriteLine("Computer wins: " + computerWins);
        Console.WriteLine("Draws: " + draws);
    }

    public void DisplayStatistics()
    {
        Console.WriteLine("====================");
        Console.WriteLine("Player wins: " + playerWins);
        Console.WriteLine("Computer wins: " + computerWins);
        Console.WriteLine("Draws: " + draws);
    }
}