class Player
{
    public List<Card> Hand { get; } = new List<Card>();

    public int Score
    {
        get
        {
            int score = 0;
            int numberOfAces = 0;

            foreach (Card card in Hand)
            {
                score += (int)card.Value;
                if (card.Value == CardValue.Ace)
                {
                    numberOfAces++;
                }
            }

            while (score > 21 && numberOfAces > 0)
            {
                score -= 10;
                numberOfAces--;
            }

            return score;
        }
    }

    public void ShowHand()
    {
        foreach (Card card in Hand)
        {
            Console.WriteLine("{0}, {1}", card.Value, card.Suit);
        }
    }
}
