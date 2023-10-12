//N24 - T2 - ordering, finding one element, pagination

//- Movie modelidan foydalaning ( name, author, rating )
//-MovieService servisidan foydalaning 

//unda quyidagi methodlar bo'lsin
//- Search ( searchKeyword ) -kinolarni avtori va nomi bo'yicha search qilib qaytarsin
//- Add ( name, author, rating ) -kinoni xuddi shu nomda va avtorda yo'q ekanligini tekshirib qo'shsin
//- GetByRating - kinolarni rating bo'yicha saralab qaytarsin

//- MovieService dan object yarating - unga kinolarni qo'shing
//- kinolarni rating bo'yicha ekranga chiqaring

var service = new MovieService();
var movies = service.Search("horror");
movies.ForEach(Console.WriteLine);

public class Movie
{
    public Movie(string name, string author, int rating)
    {
        Name = name;
        Author = author;
        Rating = rating;
    }

    public string Name { get; set; }
    public string Author { get; set; }
    public int Rating { get; set; }
}

public class MovieService
{
    public List<Movie> movies = new List<Movie>()
    {
        new Movie {"Whispers in the Wind", "Benjamin Turner", 7 },
        new Movie {"Midnight Serenade", "Emily Mitchell", 9 },
        new Movie {"Forgotten Realms", "Alexander Roberts", 6 },
        new Movie {"Starlit Secrets", "Olivia Parker", 8 },
        new Movie {"Shadows of Yesterday", "Michael Hughes", 7 },
        new Movie {"Dreams of Tomorrow", "Sophia Walker", 9 },
        new Movie {"Echoes of Destiny", "Daniel Adams", 8 },
        new Movie {"Whispers of Hope", "Lily Johnson", 7 },
        new Movie {"Rays of Eternity", "Christopher Baker", 6 }
    };

    public List<Movie> Search(string searchKeyword)
    {
        var movie = movies
            .Where(s =>
            s.Author.Equals(searchKeyword, StringComparison.OrdinalIgnoreCase)
            || s.Name.Equals(searchKeyword, StringComparison.OrdinalIgnoreCase)).ToList();
        return movie;
    }

    public void Add(string name, string author, int rating)
    {

    }

    public void GetByRating()
    {

    }
}

