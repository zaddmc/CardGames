namespace CardGames
{
    internal class Construction
    {
        static public List<Card> GetCards(bool isAceHigh, bool includeJoker)
        {
            List<Card> cards = new List<Card>
            {
                new Card(2, "a2_of_hearts.png", Card.Type.Hearts),
                new Card(2, "a2_of_diamonds.png", Card.Type.Diamonds),
                new Card(2, "a2_of_spades.png", Card.Type.Spades),
                new Card(2, "a2_of_clubs.png", Card.Type.Clubs),
                new Card(3, "a3_of_hearts.png", Card.Type.Hearts),
                new Card(3, "a3_of_diamonds.png", Card.Type.Diamonds),
                new Card(3, "a3_of_spades.png", Card.Type.Spades),
                new Card(3, "a3_of_clubs.png", Card.Type.Clubs),
                new Card(4, "a4_of_hearts.png", Card.Type.Hearts),
                new Card(4, "a4_of_diamonds.png", Card.Type.Diamonds),
                new Card(4, "a4_of_spades.png", Card.Type.Spades),
                new Card(4, "a4_of_clubs.png", Card.Type.Clubs),
                new Card(5, "a5_of_hearts.png", Card.Type.Hearts),
                new Card(5, "a5_of_diamonds.png", Card.Type.Diamonds),
                new Card(5, "a5_of_spades.png", Card.Type.Spades),
                new Card(5, "a5_of_clubs.png", Card.Type.Clubs),
                new Card(6, "a6_of_hearts.png", Card.Type.Hearts),
                new Card(6, "a6_of_diamonds.png", Card.Type.Diamonds),
                new Card(6, "a6_of_spades.png", Card.Type.Spades),
                new Card(6, "a6_of_clubs.png", Card.Type.Clubs),
                new Card(7, "a7_of_hearts.png", Card.Type.Hearts),
                new Card(7, "a7_of_diamonds.png", Card.Type.Diamonds),
                new Card(7, "a7_of_spades.png", Card.Type.Spades),
                new Card(7, "a7_of_clubs.png", Card.Type.Clubs),
                new Card(8, "a8_of_hearts.png", Card.Type.Hearts),
                new Card(8, "a8_of_diamonds.png", Card.Type.Diamonds),
                new Card(8, "a8_of_spades.png", Card.Type.Spades),
                new Card(8, "a8_of_clubs.png", Card.Type.Clubs),
                new Card(9, "a9_of_hearts.png", Card.Type.Hearts),
                new Card(9, "a9_of_diamonds.png", Card.Type.Diamonds),
                new Card(9, "a9_of_spades.png", Card.Type.Spades),
                new Card(9, "a9_of_clubs.png", Card.Type.Clubs),
                new Card(10, "a10_of_hearts.png", Card.Type.Hearts),
                new Card(10, "a10_of_diamonds.png", Card.Type.Diamonds),
                new Card(10, "a10_of_spades.png", Card.Type.Spades),
                new Card(10, "a10_of_clubs.png", Card.Type.Clubs),
                new Card(11, "jack_of_hearts.png", Card.Type.Hearts),
                new Card(11, "jack_of_diamonds.png", Card.Type.Diamonds),
                new Card(11, "jack_of_spades.png", Card.Type.Spades),
                new Card(11, "jack_of_clubs.png", Card.Type.Clubs),
                new Card(12, "queen_of_hearts.png", Card.Type.Hearts),
                new Card(12, "queen_of_diamonds.png", Card.Type.Diamonds),
                new Card(12, "queen_of_spades.png", Card.Type.Spades),
                new Card(12, "queen_of_clubs.png", Card.Type.Clubs),
                new Card(13, "king_of_hearts.png", Card.Type.Hearts),
                new Card(13, "king_of_diamonds.png", Card.Type.Diamonds),
                new Card(13, "king_of_spades.png", Card.Type.Spades),
                new Card(13, "king_of_clubs.png", Card.Type.Clubs),
            };
            if (isAceHigh)
            {
                cards.Add(new Card(14, "ace_of_hearts.png", Card.Type.Hearts));
                cards.Add(new Card(14, "ace_of_diamonds.png", Card.Type.Diamonds));
                cards.Add(new Card(14, "ace_of_spades.png", Card.Type.Spades));
                cards.Add(new Card(14, "ace_of_clubs.png", Card.Type.Clubs));
            }
            else
            {
                cards.Add(new Card(1, "ace_of_hearts.png", Card.Type.Hearts));
                cards.Add(new Card(1, "ace_of_diamonds.png", Card.Type.Diamonds));
                cards.Add(new Card(1, "ace_of_spades.png", Card.Type.Spades));
                cards.Add(new Card(1, "ace_of_clubs.png", Card.Type.Clubs));
            }
            if (includeJoker)
            {
                cards.Add(new Card(15, "red_joker.png", Card.Type.Hearts));
                cards.Add(new Card(15, "red_joker.png", Card.Type.Diamonds));
                cards.Add(new Card(15, "black_joker.png", Card.Type.Spades));
                cards.Add(new Card(15, "black_joker.png", Card.Type.Clubs));
            }
            return cards;
        }
    }
    public class Card
    {
        public enum Type
        {
            Hearts,
            Diamonds,
            Spades,
            Clubs,
        }
        public int Value { get; set; }
        public ImageSource Source { get; set; }
        public string Name { get; set; }
        public Type CardType { get; set; }

        public Card(int value, ImageSource source, Type cardType)
        {
            Value = value;
            Source = source;
            CardType = cardType;
            switch (value)
            {
                case 1:
                    Name = string.Format("{1} of {0}", cardType.ToString(), "Ace");
                    break;
                case 11:
                    Name = string.Format("{1} of {0}", cardType.ToString(), "Jack");
                    break;
                case 12:
                    Name = string.Format("{1} of {0}", cardType.ToString(), "Queen");
                    break;
                case 13:
                    Name = string.Format("{1} of {0}", cardType.ToString(), "King");
                    break;
                case 14: // in case that ace is of high value
                    Name = string.Format("{1} of {0}", cardType.ToString(), "Ace");
                    break;
                default:
                    Name = string.Format("{1} of {0}", cardType.ToString(), value);
                    break;
            }
        }
    }
    public class Player
    {
        public List<Card> PlayerCards { get; set; }
        public bool isAlive { get; set; }
        public int Wins { get; set; }
        public string Name { get; set; }

        public Player(string name)
        {
            PlayerCards = new List<Card>();
            isAlive = true;
            Wins = 0;
            Name = name;
        }
        public Player()
        {
            PlayerCards = new List<Card>();
            isAlive = true;
            Wins = 0;
            Name = "null";
        }

        public (int value, int amount) LowestValue()
        {
            int lowest = 10000;
            int amount = 0;
            for (int i = 0; i < PlayerCards.Count; i++)
            {
                if (PlayerCards[i].Value < lowest)
                {
                    lowest = PlayerCards[i].Value;
                }
            }
            if (lowest == 10000)
                return (-1, -1);

            for (int i = 0; i < PlayerCards.Count; i++)
                if (PlayerCards[i].Value == lowest)
                    amount++;

            return (lowest, amount);
        }
        public Card TakeCard(int value)
        {
            for (int i = 0; i < PlayerCards.Count; i++)
                if (PlayerCards[i].Value == value)
                {
                    PlayerCards.RemoveAt(i);
                    return PlayerCards[i];
                }
            return null;
        }

    }
}
