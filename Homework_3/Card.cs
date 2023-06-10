class Card
{
    public CardValue Value { get; }
    public CardSuit Suit { get; }

    private Card() { }

    public Card(CardValue value, CardSuit suit)
    {
        Value = value;
        Suit = suit;
    }
}
