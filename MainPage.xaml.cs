namespace CardGames;

public partial class MainPage : ContentPage
{
    static public List<Card> Deck { get; set; }
    static public List<Player> Players { get; set; }
    static public List<Card> Stack { get; set; }
    static public int rounds = 0;
    static public bool isRunning = true;
    static private Random rnd = new Random();
    public MainPage()
    {
        InitializeComponent();


        GameLoop();
    }

    static public void GameLoop()
    {
        Deck = Construction.GetCards(true, true);
        Players = InitPlayers();
        Stack = new List<Card>();

        while (isRunning)
        {
            if (Deck.Count > 0)
            {
                for (int i = Deck.Count - 1; i >= 0; i--)
                    Players[i % Players.Count].PlayerCards.Add(Deck[rnd.Next(Deck.Count)]);
            }
            while (isRunning)
            {
                for (int i = 0; i < Players.Count; i++)
                {
                    if (Stack.Count == 0)
                    {
                        var (value, amount) = Players[i].LowestValue();
                        for (int j = 0; j < amount; j++)
                            Stack.Add(Players[i].TakeCard(value));
                    }
                    else
                    {

                    }


                }
            }
        }

    }
    static public List<Player> InitPlayers()
    {
        List<Player> players = new List<Player>
        {
            new Player(),
            new Player(),
            new Player(),
            new Player(),
        };
        return players;
    }




}

