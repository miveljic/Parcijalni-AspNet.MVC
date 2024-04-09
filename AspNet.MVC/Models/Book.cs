namespace AspNet.MVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string ImeKnjige { get; set; }
        public Author Author { get; set; }
    }
}
