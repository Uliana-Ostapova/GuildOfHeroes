public class Game {
    public string Name;
    public string Genre;
    public int Release_date { get; private set; }
    public int Rating;

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