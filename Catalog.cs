public class Catalog
{
    public string Name { get; private set; }
    private List<Game> _games = new List<Game>();

    public int GameCount
    {
        get { return _games.Count; }
    }

    public Catalog(string name)
    {
        Name = name;
    }

    public bool AddGame(Game game)
    {
        if (FindGameByName(game.Name) != null)
        {
            return false;
        }

        _games.Add(game);
        return true;
    }

    public Game? FindGameByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return null;
        }
        string searchName = name.Trim();

        foreach (Game game in _games)
        {
            if (string.Equals(game.Name, searchName, StringComparison.OrdinalIgnoreCase))
            {
                return game;
            }
        }
        return null;
    }

    public bool RemoveGame(string name)
    {
        Game? game = FindGameByName(name);
        if (game == null)
        {
            return false;
        }
        return _games.Remove(game);
    }

    public List<Game> GetGames()
    {
        List<Game> result = new List<Game>();
        foreach (Game game in _games)
        {
            result.Add(game);
        }

        return result;
    }

    public int CountGamesFromYear(int year)
    {
        int count = 0;
        foreach (Game game in _games)
        {
            if (game.Release_date >= year)
            {
                count += 1;
            }
        }

        return count;
    }
}