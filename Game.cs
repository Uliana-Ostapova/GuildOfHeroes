public class Game {
    public string Name;
    public string Genre;
    public int Release_date;
    public int Rating;

    public Game(string name, string genre, int release_date)
    {
        Name = name;
        Genre = genre;
        Release_date = release_date;
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
}