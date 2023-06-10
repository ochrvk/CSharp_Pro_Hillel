class Deck
{
    private readonly List<Card> _cards = new List<Card>(36);

    public Deck()
    {
        foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
        {
            foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
            {
                _cards.Add(new Card(value, suit));
            }
        }
    }

    public void Mix()
    {
        Random random = new Random();
        int countTmp = _cards.Count;
        while (countTmp > 1)
        {
            countTmp--;
            int randomTmp = random.Next(countTmp + 1);
            Card card = _cards[randomTmp];
            _cards[randomTmp] = _cards[countTmp];
            _cards[countTmp] = card;
        }
    }

    public void Sort()
    {
        for (int i = 1; i < _cards.Count; i++)
        {
            Card card = _cards[i];
            int j = i - 1;
            while (j >= 0 && _cards[j].Value > card.Value)
            {
                _cards[j + 1] = _cards[j];
                j--;
            }
            _cards[j + 1] = card;
        }
    }

    public Card Pop()
    {
        var result = _cards[_cards.Count - 1];
        _cards.RemoveAt(_cards.Count - 1);
        return result;
    }

    public void MoveSpadesToBeginning()
    {
        List<Card> spades = _cards.Where(card => card.Suit == CardSuit.Spades).ToList();
        _cards.RemoveAll(card => card.Suit == CardSuit.Spades);
        _cards.InsertRange(0, spades);
    }

    public List<int> FindAcePositions()
    {
        List<int> acePositions = new List<int>();
        for (int i = 0; i < _cards.Count; i++)
        {
            if (_cards[i].Value == CardValue.Ace)
            {
                acePositions.Add(i);
            }
        }
        return acePositions;
    }

    public void ShowDeck()
    {
        foreach (var card in _cards)
        {
            Console.WriteLine("{0}, {1}", card.Value, card.Suit);
        }
    }
}
