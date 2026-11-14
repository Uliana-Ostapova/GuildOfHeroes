public class Game {
    private string _name = "Без названия";
    public string Name
    {
        get {
            return _name;
        }

        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _name = "Без названия";
                return;
            }

            _name = value.Trim();
        }
    }
    public string Genre;
    public int Release_date { get; private set; }
    public int Rating { get; private set; }

    public Game(string name, string genre, int release_date)
    {
        Name = name;
        Genre = genre;
        Release_date = release_date;

        if (Release_date < 1970)
        {
            Release_date = 1970;
        }
        
        Rating = 10;
    }

    public void ChangeRating(int newRating)
    {
        if (newRating < 1 || newRating > 10)
        {
            return;
        }

        Rating = newRating;
    }
    
    public void ChangeReleaseDate(int newYear)
    {
        if (newYear < 1970)
        {
            return;
        }

        Release_date = newYear;
    }
}