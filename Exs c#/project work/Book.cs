namespace project_work
{
    public class Book:IsLoaned {
        public Book()
        {
            isbn = "isbn";
            title = "title";
            authors = "authors";
            subtitle = "subtitle";
            categories = "categories";
            thumbnail = "thumbnail";
            description ="description";
            published_year ="published_year";
            average_rating = "average_rating";
            num_pages ="num_pages";
            ratings_count ="ratings_count";
            qta ="qta";
            IsLoaned = false;
        }

        public Book(string isbn, string title, string authors, string subtitle, string categories, string thumbnail, string description, string published_year, string average_rating, string num_pages, string ratings_count, string qta)
        {
            this.isbn = isbn;
            this.title = title;
            this.authors = authors;
            this.subtitle = subtitle;
            this.categories = categories;
            this.thumbnail = thumbnail;
            this.description = description;
            this.published_year = published_year;
            this.average_rating = average_rating;
            this.num_pages = num_pages;
            this.ratings_count = ratings_count;
            this.qta = qta;
            IsLoaned= false;
        }

        public string isbn { get; set; }
        public string title { get; set; }
        public string authors { get; set; }
        public string subtitle { get; set; }
        public string categories { get; set; }
        public string thumbnail { get; set; }
        public string description{ get; set; }
        public string published_year{ get; set; }
        public string average_rating{ get; set; }
        public string num_pages{ get; set; }
        public string ratings_count{ get; set; }
        public string qta{ get; set; }
        public bool IsLoaned { get ; set ; }
    }
}
